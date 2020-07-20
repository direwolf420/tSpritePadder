using System;
using System.Drawing;
using System.Windows.Forms;

namespace tSpritePadder
{
	public partial class ImageForm : Form
	{
		public ImageForm()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ResizeImage()
		{
			Image.Size = new Size(Width - 2 * 15, Height - 2 * 15 - CloseButton.Height * 2 - 2 * 5);
		}

		private void ImageForm_Resize(object sender, EventArgs e)
		{
			ResizeImage();
		}

		private void ImageForm_Load(object sender, EventArgs e)
		{
			ResizeImage();
		}
	}
}
