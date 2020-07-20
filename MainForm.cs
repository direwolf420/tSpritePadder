using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace tTilePadder
{
    public partial class tSpritePadderWindow : Form
    {
        private Bitmap flippedBitmap = null;

        private Bitmap fixedBitmap = null;

        private Bitmap unpaddedBitmap = null;

        private Bitmap finalBitmap = null;

        private RadioButton selectedPaddingColor;

        private Color PaddingColor => selectedPaddingColor?.Equals(PaddingColorTransparent) == true ? Color.Transparent : Color.Violet;

        /// <summary>
        /// Upscales x2 preserving pixels
        /// </summary>
        private Bitmap UpscaleImage(Image image)
        {
            Rectangle destRect = new Rectangle(0, 0, image.Width * 2, image.Height * 2);
            Bitmap destImage = new Bitmap(image.Width * 2, image.Height * 2);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                //graphics.CompositingMode = CompositingMode.SourceCopy;
                //graphics.CompositingQuality = CompositingQuality.HighQuality;
                //graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //graphics.SmoothingMode = SmoothingMode.HighQuality;
                //graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                //These settings make sure it's scaled perfectly x2
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.SmoothingMode = SmoothingMode.Default;

                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.AssumeLinear;
                graphics.PixelOffsetMode = PixelOffsetMode.Half;

                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);

                //using (ImageAttributes wrapMode = new ImageAttributes())
                //{
                //    //wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                //    wrapMode.SetWrapMode(WrapMode.Tile);
                //    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                //}
            }

            return destImage;
        }
        /// <summary>
        /// Returns a new bitmap that fits the cutout arguments
        /// </summary>
        private Bitmap GetResizedBitmap(Image input, int horizontal, int vertical, int cutoutWidth, int cutoutHeight, bool flipped)
        {
            int frameHeight = input.Height / (!flipped ? vertical : horizontal);

            int leftoverWidth = input.Width % cutoutWidth;
            int additionalWidth = 0;
            if (leftoverWidth > 0)
            {
                additionalWidth = cutoutWidth - leftoverWidth;
            }

            int leftoverHeight = input.Height % cutoutHeight;
            int additionalHeight = 0;
            if (leftoverHeight > 0)
            {
                additionalHeight = cutoutHeight - leftoverHeight;
            }

            if (TwoMoreAtBottom.Checked)
            {
                //Check for two pixels for each bottom row of a vertical frame
                //adjust additionalHeight
                leftoverHeight = frameHeight - cutoutHeight - 2;
                while (leftoverHeight > 0)
                {
                    if (cutoutHeight <= 0)
                    {
                        MessageBox.Show("wat you doing how is 'Cutout Size' less than 0");
                        cutoutHeight = 1;
                    }
                    leftoverHeight -= cutoutHeight;
                }
                additionalHeight = -leftoverHeight;
            }

            Bitmap expanded = GetExpandedBitmap(input, additionalWidth, additionalHeight);
            //This g now operates on expanded
            using (Graphics g = Graphics.FromImage(expanded))
            {
                g.Clear(Color.Transparent);
                //Use bottom left as anchor point for input -> expanded
                g.DrawImage(input, new Point(0, additionalHeight));
            }
            return expanded;
        }

        /// <summary>
        /// Expands the bitmap based on the arguments
        /// </summary>
        private Bitmap GetExpandedBitmap(Image input, int padAmountX, int padAmountY)
        {
            int newWidth = input.Width + padAmountX;
            int newHeight = input.Height + padAmountY;

            Bitmap resized = new Bitmap(newWidth, newHeight);
            //Because of resolution fuckery with gimp and other export mechanisms (Gimp saves as 72, constructor has 120)
            resized.SetResolution(input.HorizontalResolution, input.VerticalResolution);
            //This g now operates on resized
            using (Graphics g = Graphics.FromImage(resized))
            {
                g.Clear(Color.Transparent);
                //Use bottom left as anchor point for input -> resized
                g.DrawImage(input, new Point(0, padAmountY));
            }
            return resized;
        }

        /// <summary>
        /// Cuts the image into frames, flips if specified
        /// </summary>
        private Bitmap AdjustFrames(Image input, int horizontal, int vertical, int cutoutWidth, int cutoutHeight, bool flip)
        {
            int frameWidth = input.Width / horizontal;
            int frameHeight = input.Height / vertical;

            int leftoverWidth = frameWidth % cutoutWidth;
            int additionalWidth = 0;
            if (leftoverWidth > 0)
            {
                additionalWidth = cutoutWidth - leftoverWidth;
            }

            int leftoverHeight = frameHeight % cutoutHeight;
            int additionalHeight = 0;
            if (leftoverHeight > 0)
            {
                additionalHeight = cutoutHeight - leftoverHeight;
            }

            if (TwoMoreAtBottom.Checked)
            {
                //Check for two pixels for each bottom row of a vertical frame
                //adjust additionalHeight
                leftoverHeight = frameHeight - cutoutHeight - 2;
                while (leftoverHeight > 0)
                {
                    if (cutoutHeight <= 0)
                    {
                        MessageBox.Show("wat you doing how is 'Cutout Size' less than 0");
                        cutoutHeight = 1;
                    }
                    leftoverHeight -= cutoutHeight;
                }
                additionalHeight = -leftoverHeight;
            }

            Size oldFrameSize = new Size(frameWidth, frameHeight);
            Size newFrameSize = new Size(frameWidth + additionalWidth, frameHeight + additionalHeight);

            Bitmap final = new Bitmap((!flip ? horizontal : vertical) * newFrameSize.Width, (!flip ? vertical : horizontal) * newFrameSize.Height);
            //Because of resolution fuckery with gimp and other export mechanisms (Gimp saves as 72, constructor has 120)
            //Don't flip resolution though
            final.SetResolution(input.HorizontalResolution, input.VerticalResolution);
            using (Graphics g = Graphics.FromImage(final))
            {
                g.Clear(Color.Transparent);
                GraphicsUnit units = GraphicsUnit.Pixel;
                for (int i = 0; i < horizontal; i++)
                {
                    for (int j = 0; j < vertical; j++)
                    {
                        //Take the frame from the input image
                        RectangleF srcRect = new RectangleF(i * oldFrameSize.Width, j * oldFrameSize.Height, oldFrameSize.Width, oldFrameSize.Height);
                        //Project it onto the final image, but with padding
                        g.DrawImage(input, (!flip ? i : j) * newFrameSize.Width, (!flip ? j : i) * newFrameSize.Height + additionalHeight, srcRect, units);
                    }
                }
            }

            return final;
        }

        private Bitmap CutAndPadSingle(Image input, int horizontal, int vertical, int cutoutWidth, int cutoutHeight, int paddingX, int paddingY, bool flipped, out int cutoutCountX, out int cutoutCountY)
        {
            using (Bitmap resized = GetResizedBitmap(input, horizontal, vertical, cutoutWidth, cutoutHeight, flipped))
            {
                //Resize bitmap so it can be cut in even parts (adds padding on the top and right if necessary)

                fixedBitmap = (Bitmap)resized.Clone();

                int frameWidth = resized.Width / (!flipped ? horizontal : vertical);
                int frameHeight = resized.Height / (!flipped ? vertical : horizontal);

                cutoutCountX = resized.Width / cutoutWidth;
                cutoutCountY = resized.Height / cutoutHeight;

                if (TwoMoreAtBottom.Checked)
                {
                    //2 more height for each cutout on each new frame, imply the cutout is always the same dimensions
                    int tempHeight = resized.Height - 2 * (!flipped ? vertical : horizontal);
                    if (tempHeight <= 0)
                    {
                        tempHeight = 1;
                    }
                    cutoutCountY = tempHeight / cutoutHeight;
                }

                Bitmap final = GetExpandedBitmap(resized, cutoutCountX * paddingX, cutoutCountY * paddingY);
                //Resize bitmap so it can be cut in even parts including padding (adds padding on the top and right if necessary)

                unpaddedBitmap = (Bitmap)final.Clone();

                if (paddingX == 0 && paddingY == 0) return final;
                //No point drawing the final image with no padding
                int cutoutPerFrame = cutoutCountY / (!flipped ? vertical : horizontal);

                using (Graphics g = Graphics.FromImage(final))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.Clear(PaddingColor);
                    GraphicsUnit units = GraphicsUnit.Pixel;
                    for (int i = 0; i < cutoutCountX; i++)
                    {
                        int padWidth = cutoutWidth + paddingX;
                        int srcX = i * cutoutWidth + (int)HorizontalOffsetNumber.Value;
                        int srcY = (int)VerticalOffsetNumber.Value;
                        int padY = 0;
                        for (int j = 0; j < cutoutCountY; j++)
                        {
                            //Use j not as a variable to define coordinates here, rely on srcY, padY

                            int srcHeight = cutoutHeight;
                            if (TwoMoreAtBottom.Checked)
                            {
                                //j % cutoutPerFrame checks which cutout# on a frame we are on
                                //Example: 3 frames, 6 cutouts: each frame as 2 cutouts ('0' and '1')
                                //If the cutout# is the max number of cutouts - 1 (bottommost cutout), add 2
                                if (j % cutoutPerFrame == cutoutPerFrame - 1)
                                {
                                    srcHeight += 2;
                                }
                            }

                            //Take the cutout from the resized image
                            RectangleF srcRect = new RectangleF(srcX, srcY, cutoutWidth, srcHeight);
                            srcY += srcHeight;

                            //Project it onto the final image, but with padding
                            g.DrawImage(resized, i * padWidth, padY, srcRect, units);
                            padY += srcHeight + paddingY;
                        }
                    }
                }

                return final;
            }
        }

        private void UpdateImages()
        {
            Image next = InputImage.InitialImage;
            if (InputImage.Image != null)
            {
                next = InputImage.Image;
            }
            else
            {
                InputImage.Image = InputImage.InitialImage;
            }

            if (Upscale2.Checked)
            {
                next = UpscaleImage(next);
            }

            Bitmap framed = AdjustFrames(next, (int)HorizontalCountNumber.Value, (int)VerticalCountNumber.Value, (int)CutoutNumber.Value, (int)CutoutNumber.Value, FlipDimensions.Checked);

            flippedBitmap = (Bitmap)framed.Clone();

            Bitmap final = CutAndPadSingle(framed, (int)HorizontalCountNumber.Value, (int)VerticalCountNumber.Value, (int)CutoutNumber.Value, (int)CutoutNumber.Value, (int)PaddingNumber.Value, (int)PaddingNumber.Value, FlipDimensions.Checked, out int cutoutCountX, out int cutoutCountY);

            finalBitmap = (Bitmap)final.Clone();

            OutputImage.Image = final;
            OutputImageLabel.Text = $"Output: {OutputImage.Image.Width}x{OutputImage.Image.Height}";

            //Example:
            //static : 3 x 1 frames
            //no Flip: 15 x 2
            //Flipped: 5 x 6
            //Result should always be 5 x 2 
            int horizontalCuts = !FlipDimensions.Checked ? cutoutCountX : cutoutCountX * (int)HorizontalCountNumber.Value;
            int verticalCuts = !FlipDimensions.Checked ? cutoutCountY : cutoutCountY / (int)HorizontalCountNumber.Value;
            int horizontalCutsPerFrame = horizontalCuts / (int)HorizontalCountNumber.Value;
            int verticalCutsPerFrame = verticalCuts / (int)VerticalCountNumber.Value;
            OutputFrameLabel.Text = $"Cutouts per frame: {horizontalCutsPerFrame}x{verticalCutsPerFrame}";
        }

        public tSpritePadderWindow()
        {
            InitializeComponent();
        }

        #region ValueChanged
        private void CutoutNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void PaddingNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void HorizontalCountNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void VerticalCountNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void HorizontalOffsetNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void VerticalOffsetNumber_ValueChanged(object sender, EventArgs e)
        {
            UpdateImages();
        }
        #endregion

        #region Click
        private void Upscale2_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void FlipDimensions_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void TwoMoreAtBottom_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void SaveFlipped_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void SaveFixed_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void SaveUnpadded_Click(object sender, EventArgs e)
        {
            UpdateImages();
        }

        private void ShowImage(PictureBox pictureBox)
        {
            ImageForm imageForm = new ImageForm();
            imageForm.Image.Image = pictureBox.Image;
            imageForm.Image.BackColor = pictureBox.BackColor;
            imageForm.ShowDialog();
        }

        private void InputImage_Click(object sender, EventArgs e)
        {
            ShowImage(InputImage);
        }

        private void OutputImage_Click(object sender, EventArgs e)
        {
            ShowImage(OutputImage);
        }

        private void TargetFolderButton_Click(object sender, EventArgs e)
        {
            ImageSelectDialog.ShowDialog();
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            ChooseFolderDialog.ShowDialog();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (ImageSelectDialog.FileName == string.Empty)
            {
                MessageBox.Show("Please choose a file");
                return;
            }
            else if (ChooseFolderDialog.SelectedPath == string.Empty)
            {
                MessageBox.Show("Please choose a folder");
                return;
            }
            int count = ImageSelectDialog.FileName.Length;
            string suffix = ".png";
            string firstHalf = ImageSelectDialog.FileName.Substring(0, count - suffix.Length);
            string[] strings = firstHalf.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string fileName = strings.Last();

            try
            {
                string prefix = $"{ChooseFolderDialog.SelectedPath}\\{Text}_{fileName}";
                List<string> savedFiles = new List<string>();

                string name = "final";
                finalBitmap?.Save($"{prefix}_{name}{suffix}", ImageFormat.Png);
                savedFiles.Add(name);
                if (SaveFlipped.Checked && flippedBitmap != null)
                {
                    name = "flipped";
                    flippedBitmap.Save($"{prefix}_{name}{suffix}", ImageFormat.Png);
                    savedFiles.Add(name);
                }
                if (SaveFixed.Checked && fixedBitmap != null)
                {
                    name = "fixed";
                    fixedBitmap.Save($"{prefix}_{name}{suffix}", ImageFormat.Png);
                    savedFiles.Add(name);
                }
                if (SaveUnpadded.Checked && unpaddedBitmap != null)
                {
                    name = "unpadded";
                    unpaddedBitmap.Save($"{prefix}_{name}{suffix}", ImageFormat.Png);
                    savedFiles.Add(name);
                }

                string names = string.Empty;
                foreach (var file in savedFiles)
                {
                    names += $"\r\n{Text}_{fileName}_{file}{suffix}";
                }
                MessageBox.Show("The following have been saved to " +
                    ChooseFolderDialog.SelectedPath + ":" + names);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        #endregion

        private void InputSelectDialog_FileOk(object sender, CancelEventArgs e)
        {
            int count = ImageSelectDialog.FileName.Length;
            string suffix = ".png";
            string firstHalf = ImageSelectDialog.FileName.Substring(0, count - suffix.Length);
            string[] strings = firstHalf.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string fileName = strings.Last();
            InputLabel.Text = fileName;
            InputImage.Image = Image.FromFile(ImageSelectDialog.FileName);
            InputImageLabel.Text = $"Input: {InputImage.Image.Width}x{InputImage.Image.Height}";
            UpdateImages();
        }

        private void tSpritePadderWindow_Resize(object sender, EventArgs e)
        {
            InputImageLabel.Anchor = InputImage.Anchor;
            OutputImageLabel.Anchor = OutputImage.Anchor;
        }

        private void UpdatePaddingColor(object sender)
        {
            if (!(sender is RadioButton rb))
            {
                return;
            }

            //Ensure that the RadioButton.Checked property changed to true
            if (rb.Checked)
            {
                //Keep track of the selected RadioButton by saving a reference to it
                selectedPaddingColor = rb;

                UpdateImages();
            }
        }

        private void PaddingColorDefault_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePaddingColor(sender);
        }

        private void PaddingColorTransparent_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePaddingColor(sender);
        }

        private void PreviewColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                InputImage.BackColor = colorDialog1.Color;
                OutputImage.BackColor = colorDialog1.Color;
            }
        }

        private void tSpritePadderWindow_Load(object sender, EventArgs e)
        {
            UpdateImages();
        }
    }
}
