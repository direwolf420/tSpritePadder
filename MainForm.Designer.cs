namespace tTilePadder
{
    partial class tSpritePadderWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();

                flippedBitmap.Dispose();
                fixedBitmap.Dispose();
                unpaddedBitmap.Dispose();
                finalBitmap.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tSpritePadderWindow));
            this.InputSelectButton = new System.Windows.Forms.Button();
            this.InputLabel = new System.Windows.Forms.Label();
            this.ImageSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.CutoutNumber = new System.Windows.Forms.NumericUpDown();
            this.CutoutLabel = new System.Windows.Forms.Label();
            this.PaddingLabel = new System.Windows.Forms.Label();
            this.PaddingNumber = new System.Windows.Forms.NumericUpDown();
            this.InputImage = new System.Windows.Forms.PictureBox();
            this.ChooseFolderButton = new System.Windows.Forms.Button();
            this.ChooseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.GoButton = new System.Windows.Forms.Button();
            this.OutputImage = new System.Windows.Forms.PictureBox();
            this.InputImageLabel = new System.Windows.Forms.Label();
            this.OutputImageLabel = new System.Windows.Forms.Label();
            this.FlipDimensions = new System.Windows.Forms.CheckBox();
            this.SaveFixed = new System.Windows.Forms.CheckBox();
            this.SaveUnpadded = new System.Windows.Forms.CheckBox();
            this.SaveFlipped = new System.Windows.Forms.CheckBox();
            this.MouseOver = new System.Windows.Forms.ToolTip(this.components);
            this.HorizontalCountLabel = new System.Windows.Forms.Label();
            this.VerticalCountLabel = new System.Windows.Forms.Label();
            this.Upscale2 = new System.Windows.Forms.CheckBox();
            this.HorizontalOffsetLabel = new System.Windows.Forms.Label();
            this.VerticalOffsetLabel = new System.Windows.Forms.Label();
            this.TwoMoreAtBottom = new System.Windows.Forms.CheckBox();
            this.PreviewColorButton = new System.Windows.Forms.Button();
            this.HorizontalCountNumber = new System.Windows.Forms.NumericUpDown();
            this.VerticalCountNumber = new System.Windows.Forms.NumericUpDown();
            this.OutputFrameLabel = new System.Windows.Forms.Label();
            this.PaddingColorTransparent = new System.Windows.Forms.RadioButton();
            this.PaddingColorDefault = new System.Windows.Forms.RadioButton();
            this.PaddingColorGroup = new System.Windows.Forms.GroupBox();
            this.OptionalSettingsGroup = new System.Windows.Forms.GroupBox();
            this.NumberGroup = new System.Windows.Forms.GroupBox();
            this.VerticalOffsetNumber = new System.Windows.Forms.NumericUpDown();
            this.HorizontalOffsetNumber = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CutoutNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalCountNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalCountNumber)).BeginInit();
            this.PaddingColorGroup.SuspendLayout();
            this.OptionalSettingsGroup.SuspendLayout();
            this.NumberGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalOffsetNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalOffsetNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // InputSelectButton
            // 
            this.InputSelectButton.Location = new System.Drawing.Point(356, 8);
            this.InputSelectButton.Name = "InputSelectButton";
            this.InputSelectButton.Size = new System.Drawing.Size(126, 23);
            this.InputSelectButton.TabIndex = 1;
            this.InputSelectButton.Text = "Select Image";
            this.MouseOver.SetToolTip(this.InputSelectButton, "Select an image");
            this.InputSelectButton.UseVisualStyleBackColor = true;
            this.InputSelectButton.Click += new System.EventHandler(this.TargetFolderButton_Click);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InputLabel.Location = new System.Drawing.Point(12, 14);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(194, 17);
            this.InputLabel.TabIndex = 2;
            this.InputLabel.Text = "Press \"Select Image\" To Start";
            // 
            // ImageSelectDialog
            // 
            this.ImageSelectDialog.DefaultExt = "png";
            this.ImageSelectDialog.Filter = "png files (*.png)|*.png";
            this.ImageSelectDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InputSelectDialog_FileOk);
            // 
            // CutoutNumber
            // 
            this.CutoutNumber.Location = new System.Drawing.Point(14, 38);
            this.CutoutNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.CutoutNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CutoutNumber.Name = "CutoutNumber";
            this.CutoutNumber.Size = new System.Drawing.Size(120, 22);
            this.CutoutNumber.TabIndex = 3;
            this.CutoutNumber.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.CutoutNumber.ValueChanged += new System.EventHandler(this.CutoutNumber_ValueChanged);
            // 
            // CutoutLabel
            // 
            this.CutoutLabel.AutoSize = true;
            this.CutoutLabel.Location = new System.Drawing.Point(11, 18);
            this.CutoutLabel.Name = "CutoutLabel";
            this.CutoutLabel.Size = new System.Drawing.Size(80, 17);
            this.CutoutLabel.TabIndex = 4;
            this.CutoutLabel.Text = "Cutout Size";
            this.MouseOver.SetToolTip(this.CutoutLabel, "The size of the squares for the cutout");
            // 
            // PaddingLabel
            // 
            this.PaddingLabel.AutoSize = true;
            this.PaddingLabel.Location = new System.Drawing.Point(11, 63);
            this.PaddingLabel.Name = "PaddingLabel";
            this.PaddingLabel.Size = new System.Drawing.Size(91, 17);
            this.PaddingLabel.TabIndex = 5;
            this.PaddingLabel.Text = "Padding Size";
            this.MouseOver.SetToolTip(this.PaddingLabel, "Padding between the cutouts (top and left has no padding)");
            // 
            // PaddingNumber
            // 
            this.PaddingNumber.Location = new System.Drawing.Point(14, 83);
            this.PaddingNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.PaddingNumber.Name = "PaddingNumber";
            this.PaddingNumber.Size = new System.Drawing.Size(120, 22);
            this.PaddingNumber.TabIndex = 6;
            this.PaddingNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PaddingNumber.ValueChanged += new System.EventHandler(this.PaddingNumber_ValueChanged);
            // 
            // InputImage
            // 
            this.InputImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InputImage.BackColor = System.Drawing.Color.GhostWhite;
            this.InputImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("InputImage.InitialImage")));
            this.InputImage.Location = new System.Drawing.Point(12, 382);
            this.InputImage.Name = "InputImage";
            this.InputImage.Size = new System.Drawing.Size(214, 205);
            this.InputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InputImage.TabIndex = 7;
            this.InputImage.TabStop = false;
            this.MouseOver.SetToolTip(this.InputImage, "Click to open in window");
            this.InputImage.Click += new System.EventHandler(this.InputImage_Click);
            // 
            // ChooseFolderButton
            // 
            this.ChooseFolderButton.Location = new System.Drawing.Point(356, 52);
            this.ChooseFolderButton.Name = "ChooseFolderButton";
            this.ChooseFolderButton.Size = new System.Drawing.Size(126, 23);
            this.ChooseFolderButton.TabIndex = 8;
            this.ChooseFolderButton.Text = "Choose Folder";
            this.MouseOver.SetToolTip(this.ChooseFolderButton, "Choose save folder");
            this.ChooseFolderButton.UseVisualStyleBackColor = true;
            this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(386, 95);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(68, 23);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go";
            this.MouseOver.SetToolTip(this.GoButton, "Save image(s) with specified settings");
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // OutputImage
            // 
            this.OutputImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputImage.BackColor = System.Drawing.Color.GhostWhite;
            this.OutputImage.Location = new System.Drawing.Point(270, 382);
            this.OutputImage.Name = "OutputImage";
            this.OutputImage.Size = new System.Drawing.Size(214, 205);
            this.OutputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OutputImage.TabIndex = 10;
            this.OutputImage.TabStop = false;
            this.MouseOver.SetToolTip(this.OutputImage, "Click to open in window");
            this.OutputImage.Click += new System.EventHandler(this.OutputImage_Click);
            // 
            // InputImageLabel
            // 
            this.InputImageLabel.AutoSize = true;
            this.InputImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.InputImageLabel.Location = new System.Drawing.Point(9, 362);
            this.InputImageLabel.Name = "InputImageLabel";
            this.InputImageLabel.Size = new System.Drawing.Size(39, 17);
            this.InputImageLabel.TabIndex = 11;
            this.InputImageLabel.Text = "Input";
            // 
            // OutputImageLabel
            // 
            this.OutputImageLabel.AutoSize = true;
            this.OutputImageLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputImageLabel.Location = new System.Drawing.Point(267, 362);
            this.OutputImageLabel.Name = "OutputImageLabel";
            this.OutputImageLabel.Size = new System.Drawing.Size(51, 17);
            this.OutputImageLabel.TabIndex = 12;
            this.OutputImageLabel.Text = "Output";
            // 
            // FlipDimensions
            // 
            this.FlipDimensions.AutoSize = true;
            this.FlipDimensions.Location = new System.Drawing.Point(14, 48);
            this.FlipDimensions.Name = "FlipDimensions";
            this.FlipDimensions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FlipDimensions.Size = new System.Drawing.Size(129, 21);
            this.FlipDimensions.TabIndex = 13;
            this.FlipDimensions.Text = "Flip Dimensions";
            this.MouseOver.SetToolTip(this.FlipDimensions, "Flip the frames before padding");
            this.FlipDimensions.Click += new System.EventHandler(this.FlipDimensions_Click);
            // 
            // SaveFixed
            // 
            this.SaveFixed.AutoSize = true;
            this.SaveFixed.Location = new System.Drawing.Point(14, 129);
            this.SaveFixed.Name = "SaveFixed";
            this.SaveFixed.Size = new System.Drawing.Size(99, 21);
            this.SaveFixed.TabIndex = 14;
            this.SaveFixed.Text = "Save Fixed";
            this.MouseOver.SetToolTip(this.SaveFixed, "Save the cutout-adjusted input image");
            this.SaveFixed.Click += new System.EventHandler(this.SaveFixed_Click);
            // 
            // SaveUnpadded
            // 
            this.SaveUnpadded.AutoSize = true;
            this.SaveUnpadded.Location = new System.Drawing.Point(14, 156);
            this.SaveUnpadded.Name = "SaveUnpadded";
            this.SaveUnpadded.Size = new System.Drawing.Size(132, 21);
            this.SaveUnpadded.TabIndex = 15;
            this.SaveUnpadded.Text = "Save Unpadded";
            this.MouseOver.SetToolTip(this.SaveUnpadded, "Save the cutout+padding-adjusted input image");
            this.SaveUnpadded.Click += new System.EventHandler(this.SaveUnpadded_Click);
            // 
            // SaveFlipped
            // 
            this.SaveFlipped.AutoSize = true;
            this.SaveFlipped.Location = new System.Drawing.Point(14, 102);
            this.SaveFlipped.Name = "SaveFlipped";
            this.SaveFlipped.Size = new System.Drawing.Size(112, 21);
            this.SaveFlipped.TabIndex = 16;
            this.SaveFlipped.Text = "Save Flipped";
            this.MouseOver.SetToolTip(this.SaveFlipped, "Save the flipped version of the input image");
            this.SaveFlipped.Click += new System.EventHandler(this.SaveFlipped_Click);
            // 
            // MouseOver
            // 
            this.MouseOver.AutoPopDelay = 5000;
            this.MouseOver.InitialDelay = 500;
            this.MouseOver.ReshowDelay = 100;
            // 
            // HorizontalCountLabel
            // 
            this.HorizontalCountLabel.AutoSize = true;
            this.HorizontalCountLabel.Location = new System.Drawing.Point(11, 108);
            this.HorizontalCountLabel.Name = "HorizontalCountLabel";
            this.HorizontalCountLabel.Size = new System.Drawing.Size(131, 17);
            this.HorizontalCountLabel.TabIndex = 17;
            this.HorizontalCountLabel.Text = "#Horizontal Frames";
            this.MouseOver.SetToolTip(this.HorizontalCountLabel, "Number of horizontal frames the input image has");
            // 
            // VerticalCountLabel
            // 
            this.VerticalCountLabel.AutoSize = true;
            this.VerticalCountLabel.Location = new System.Drawing.Point(11, 153);
            this.VerticalCountLabel.Name = "VerticalCountLabel";
            this.VerticalCountLabel.Size = new System.Drawing.Size(114, 17);
            this.VerticalCountLabel.TabIndex = 19;
            this.VerticalCountLabel.Text = "#Vertical Frames";
            this.MouseOver.SetToolTip(this.VerticalCountLabel, "Number of vertical frames the input image has");
            // 
            // Upscale2
            // 
            this.Upscale2.AutoSize = true;
            this.Upscale2.Location = new System.Drawing.Point(14, 21);
            this.Upscale2.Name = "Upscale2";
            this.Upscale2.Size = new System.Drawing.Size(99, 21);
            this.Upscale2.TabIndex = 23;
            this.Upscale2.Text = "Upscale x2";
            this.MouseOver.SetToolTip(this.Upscale2, "Upscale image x2 before padding");
            this.Upscale2.UseVisualStyleBackColor = true;
            this.Upscale2.Click += new System.EventHandler(this.Upscale2_Click);
            // 
            // HorizontalOffsetLabel
            // 
            this.HorizontalOffsetLabel.AutoSize = true;
            this.HorizontalOffsetLabel.Location = new System.Drawing.Point(11, 198);
            this.HorizontalOffsetLabel.Name = "HorizontalOffsetLabel";
            this.HorizontalOffsetLabel.Size = new System.Drawing.Size(114, 17);
            this.HorizontalOffsetLabel.TabIndex = 21;
            this.HorizontalOffsetLabel.Text = "Horizontal Offset";
            this.MouseOver.SetToolTip(this.HorizontalOffsetLabel, "Number of vertical frames the input image has");
            // 
            // VerticalOffsetLabel
            // 
            this.VerticalOffsetLabel.AutoSize = true;
            this.VerticalOffsetLabel.Location = new System.Drawing.Point(11, 243);
            this.VerticalOffsetLabel.Name = "VerticalOffsetLabel";
            this.VerticalOffsetLabel.Size = new System.Drawing.Size(97, 17);
            this.VerticalOffsetLabel.TabIndex = 23;
            this.VerticalOffsetLabel.Text = "Vertical Offset";
            this.MouseOver.SetToolTip(this.VerticalOffsetLabel, "Number of vertical frames the input image has");
            // 
            // TwoMoreAtBottom
            // 
            this.TwoMoreAtBottom.AutoSize = true;
            this.TwoMoreAtBottom.Location = new System.Drawing.Point(14, 75);
            this.TwoMoreAtBottom.Name = "TwoMoreAtBottom";
            this.TwoMoreAtBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TwoMoreAtBottom.Size = new System.Drawing.Size(155, 21);
            this.TwoMoreAtBottom.TabIndex = 24;
            this.TwoMoreAtBottom.Text = "2 More Bottom Pixel";
            this.MouseOver.SetToolTip(this.TwoMoreAtBottom, "Two more pixel at the bottom row of each frame");
            this.TwoMoreAtBottom.Click += new System.EventHandler(this.TwoMoreAtBottom_Click);
            // 
            // PreviewColorButton
            // 
            this.PreviewColorButton.Location = new System.Drawing.Point(358, 296);
            this.PreviewColorButton.Name = "PreviewColorButton";
            this.PreviewColorButton.Size = new System.Drawing.Size(126, 46);
            this.PreviewColorButton.TabIndex = 30;
            this.PreviewColorButton.Text = "Change Preview Color";
            this.MouseOver.SetToolTip(this.PreviewColorButton, "Change background color on the preview images");
            this.PreviewColorButton.UseVisualStyleBackColor = true;
            this.PreviewColorButton.Click += new System.EventHandler(this.PreviewColorButton_Click);
            // 
            // HorizontalCountNumber
            // 
            this.HorizontalCountNumber.Location = new System.Drawing.Point(14, 128);
            this.HorizontalCountNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.HorizontalCountNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorizontalCountNumber.Name = "HorizontalCountNumber";
            this.HorizontalCountNumber.Size = new System.Drawing.Size(120, 22);
            this.HorizontalCountNumber.TabIndex = 18;
            this.HorizontalCountNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorizontalCountNumber.ValueChanged += new System.EventHandler(this.HorizontalCountNumber_ValueChanged);
            // 
            // VerticalCountNumber
            // 
            this.VerticalCountNumber.Location = new System.Drawing.Point(14, 173);
            this.VerticalCountNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.VerticalCountNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VerticalCountNumber.Name = "VerticalCountNumber";
            this.VerticalCountNumber.Size = new System.Drawing.Size(120, 22);
            this.VerticalCountNumber.TabIndex = 20;
            this.VerticalCountNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VerticalCountNumber.ValueChanged += new System.EventHandler(this.VerticalCountNumber_ValueChanged);
            // 
            // OutputFrameLabel
            // 
            this.OutputFrameLabel.AutoSize = true;
            this.OutputFrameLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputFrameLabel.Location = new System.Drawing.Point(267, 345);
            this.OutputFrameLabel.Name = "OutputFrameLabel";
            this.OutputFrameLabel.Size = new System.Drawing.Size(126, 17);
            this.OutputFrameLabel.TabIndex = 22;
            this.OutputFrameLabel.Text = "Cutouts Per Frame";
            // 
            // PaddingColorTransparent
            // 
            this.PaddingColorTransparent.AutoSize = true;
            this.PaddingColorTransparent.Location = new System.Drawing.Point(14, 54);
            this.PaddingColorTransparent.Name = "PaddingColorTransparent";
            this.PaddingColorTransparent.Size = new System.Drawing.Size(107, 21);
            this.PaddingColorTransparent.TabIndex = 24;
            this.PaddingColorTransparent.Text = "Transparent";
            this.PaddingColorTransparent.UseVisualStyleBackColor = true;
            this.PaddingColorTransparent.CheckedChanged += new System.EventHandler(this.PaddingColorTransparent_CheckedChanged);
            // 
            // PaddingColorDefault
            // 
            this.PaddingColorDefault.AutoSize = true;
            this.PaddingColorDefault.Checked = true;
            this.PaddingColorDefault.Location = new System.Drawing.Point(14, 27);
            this.PaddingColorDefault.Name = "PaddingColorDefault";
            this.PaddingColorDefault.Size = new System.Drawing.Size(74, 21);
            this.PaddingColorDefault.TabIndex = 25;
            this.PaddingColorDefault.TabStop = true;
            this.PaddingColorDefault.Text = "Default";
            this.PaddingColorDefault.UseVisualStyleBackColor = true;
            this.PaddingColorDefault.CheckedChanged += new System.EventHandler(this.PaddingColorDefault_CheckedChanged);
            // 
            // PaddingColorGroup
            // 
            this.PaddingColorGroup.BackColor = System.Drawing.Color.Transparent;
            this.PaddingColorGroup.Controls.Add(this.PaddingColorTransparent);
            this.PaddingColorGroup.Controls.Add(this.PaddingColorDefault);
            this.PaddingColorGroup.Location = new System.Drawing.Point(164, 256);
            this.PaddingColorGroup.Name = "PaddingColorGroup";
            this.PaddingColorGroup.Size = new System.Drawing.Size(186, 86);
            this.PaddingColorGroup.TabIndex = 27;
            this.PaddingColorGroup.TabStop = false;
            this.PaddingColorGroup.Text = "Padding Color";
            // 
            // OptionalSettingsGroup
            // 
            this.OptionalSettingsGroup.BackColor = System.Drawing.Color.Transparent;
            this.OptionalSettingsGroup.Controls.Add(this.TwoMoreAtBottom);
            this.OptionalSettingsGroup.Controls.Add(this.Upscale2);
            this.OptionalSettingsGroup.Controls.Add(this.FlipDimensions);
            this.OptionalSettingsGroup.Controls.Add(this.SaveFlipped);
            this.OptionalSettingsGroup.Controls.Add(this.SaveFixed);
            this.OptionalSettingsGroup.Controls.Add(this.SaveUnpadded);
            this.OptionalSettingsGroup.Location = new System.Drawing.Point(164, 58);
            this.OptionalSettingsGroup.Name = "OptionalSettingsGroup";
            this.OptionalSettingsGroup.Size = new System.Drawing.Size(186, 195);
            this.OptionalSettingsGroup.TabIndex = 28;
            this.OptionalSettingsGroup.TabStop = false;
            this.OptionalSettingsGroup.Text = "Optional Settings";
            // 
            // NumberGroup
            // 
            this.NumberGroup.BackColor = System.Drawing.Color.Transparent;
            this.NumberGroup.Controls.Add(this.VerticalOffsetNumber);
            this.NumberGroup.Controls.Add(this.VerticalOffsetLabel);
            this.NumberGroup.Controls.Add(this.HorizontalOffsetNumber);
            this.NumberGroup.Controls.Add(this.HorizontalOffsetLabel);
            this.NumberGroup.Controls.Add(this.CutoutLabel);
            this.NumberGroup.Controls.Add(this.CutoutNumber);
            this.NumberGroup.Controls.Add(this.PaddingLabel);
            this.NumberGroup.Controls.Add(this.PaddingNumber);
            this.NumberGroup.Controls.Add(this.VerticalCountNumber);
            this.NumberGroup.Controls.Add(this.HorizontalCountLabel);
            this.NumberGroup.Controls.Add(this.VerticalCountLabel);
            this.NumberGroup.Controls.Add(this.HorizontalCountNumber);
            this.NumberGroup.Location = new System.Drawing.Point(12, 58);
            this.NumberGroup.Name = "NumberGroup";
            this.NumberGroup.Size = new System.Drawing.Size(146, 301);
            this.NumberGroup.TabIndex = 29;
            this.NumberGroup.TabStop = false;
            this.NumberGroup.Text = "Numbers";
            // 
            // VerticalOffsetNumber
            // 
            this.VerticalOffsetNumber.Location = new System.Drawing.Point(14, 263);
            this.VerticalOffsetNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.VerticalOffsetNumber.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.VerticalOffsetNumber.Name = "VerticalOffsetNumber";
            this.VerticalOffsetNumber.Size = new System.Drawing.Size(120, 22);
            this.VerticalOffsetNumber.TabIndex = 24;
            this.VerticalOffsetNumber.ValueChanged += new System.EventHandler(this.VerticalOffsetNumber_ValueChanged);
            // 
            // HorizontalOffsetNumber
            // 
            this.HorizontalOffsetNumber.Location = new System.Drawing.Point(14, 218);
            this.HorizontalOffsetNumber.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.HorizontalOffsetNumber.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.HorizontalOffsetNumber.Name = "HorizontalOffsetNumber";
            this.HorizontalOffsetNumber.Size = new System.Drawing.Size(120, 22);
            this.HorizontalOffsetNumber.TabIndex = 22;
            this.HorizontalOffsetNumber.ValueChanged += new System.EventHandler(this.HorizontalOffsetNumber_ValueChanged);
            // 
            // tSpritePadderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 599);
            this.Controls.Add(this.PreviewColorButton);
            this.Controls.Add(this.NumberGroup);
            this.Controls.Add(this.PaddingColorGroup);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.ChooseFolderButton);
            this.Controls.Add(this.InputSelectButton);
            this.Controls.Add(this.OptionalSettingsGroup);
            this.Controls.Add(this.OutputFrameLabel);
            this.Controls.Add(this.OutputImageLabel);
            this.Controls.Add(this.InputImageLabel);
            this.Controls.Add(this.OutputImage);
            this.Controls.Add(this.InputImage);
            this.Controls.Add(this.InputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(502, 630);
            this.MinimumSize = new System.Drawing.Size(502, 630);
            this.Name = "tSpritePadderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tSpritePadder";
            this.Load += new System.EventHandler(this.tSpritePadderWindow_Load);
            this.Resize += new System.EventHandler(this.tSpritePadderWindow_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.CutoutNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaddingNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalCountNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalCountNumber)).EndInit();
            this.PaddingColorGroup.ResumeLayout(false);
            this.PaddingColorGroup.PerformLayout();
            this.OptionalSettingsGroup.ResumeLayout(false);
            this.OptionalSettingsGroup.PerformLayout();
            this.NumberGroup.ResumeLayout(false);
            this.NumberGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalOffsetNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalOffsetNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InputSelectButton;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.OpenFileDialog ImageSelectDialog;
        private System.Windows.Forms.NumericUpDown CutoutNumber;
        private System.Windows.Forms.Label CutoutLabel;
        private System.Windows.Forms.Label PaddingLabel;
        private System.Windows.Forms.NumericUpDown PaddingNumber;
        private System.Windows.Forms.PictureBox InputImage;
        private System.Windows.Forms.Button ChooseFolderButton;
        private System.Windows.Forms.FolderBrowserDialog ChooseFolderDialog;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.PictureBox OutputImage;
        private System.Windows.Forms.Label InputImageLabel;
        private System.Windows.Forms.Label OutputImageLabel;
        private System.Windows.Forms.CheckBox FlipDimensions;
        private System.Windows.Forms.CheckBox SaveFixed;
        private System.Windows.Forms.CheckBox SaveUnpadded;
        private System.Windows.Forms.CheckBox SaveFlipped;
        private System.Windows.Forms.ToolTip MouseOver;
        private System.Windows.Forms.NumericUpDown HorizontalCountNumber;
        private System.Windows.Forms.Label HorizontalCountLabel;
        private System.Windows.Forms.NumericUpDown VerticalCountNumber;
        private System.Windows.Forms.Label VerticalCountLabel;
        private System.Windows.Forms.Label OutputFrameLabel;
        private System.Windows.Forms.CheckBox Upscale2;
        private System.Windows.Forms.RadioButton PaddingColorTransparent;
        private System.Windows.Forms.RadioButton PaddingColorDefault;
        private System.Windows.Forms.GroupBox PaddingColorGroup;
        private System.Windows.Forms.GroupBox OptionalSettingsGroup;
        private System.Windows.Forms.GroupBox NumberGroup;
        private System.Windows.Forms.NumericUpDown VerticalOffsetNumber;
        private System.Windows.Forms.Label VerticalOffsetLabel;
        private System.Windows.Forms.NumericUpDown HorizontalOffsetNumber;
        private System.Windows.Forms.Label HorizontalOffsetLabel;
        private System.Windows.Forms.CheckBox TwoMoreAtBottom;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button PreviewColorButton;
    }
}

