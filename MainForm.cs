using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFileIOWinForm
{
	

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private async void btnAsyncCopy_Click(object sender, EventArgs e)
		{
			long totalCopied = await CopyAsync(txtSource.Text, txtTarget.Text);
		}

		private void btnSyncCopy_Click(object sender, EventArgs e)
		{
			long totalCopied = CopySync(txtSource.Text, txtTarget.Text);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			MessageBox.Show("UI 반응 테스트 성공.");
		}

		private void btnFindSource_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtSource.Text = dlg.FileName;
			}
		}

		private void btnFindTarget_Click(object sender, EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtTarget.Text = dlg.FileName;
			}
		}

		private async Task<long> CopyAsync(string FromPath, string ToPath)
		{
			btnSyncCopy.Enabled = false;
			long totalCopied = 0;

			// 복사대상을 읽어서 버퍼에 저장하는 스트림
			using (FileStream fromStream = new FileStream(FromPath, FileMode.Open))
			{
				// 버퍼에 저장된 내용을 불러와 파일을 생성하는 스트림
				using (FileStream toStream = new FileStream(ToPath, FileMode.Create))
				{
					byte[] buffer = new byte[1024 * 1024];
					int nRead = 0;

					// fromStream.ReadAsync로 파일을 읽어 buffer에 저장
					while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
					{
						// toStream.WriteAsync를 이용해 buffer에 저장된 데이터를 새로운 파일에 작성
						await toStream.WriteAsync(buffer, 0, nRead);
						totalCopied += nRead;   // 한 세트 끝날때마다의 용량을 누적합산

						pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);
					}
				}
			}

			btnSyncCopy.Enabled = true;
			return totalCopied;
		}

		private long CopySync(string FromPath, string ToPath)
		{
			btnAsyncCopy.Enabled = false;
			long totalCopied = 0;

			// 복사대상을 읽어서 버퍼에 저장하는 스트림
			using (FileStream fromStream = new FileStream(FromPath, FileMode.Open))
			{
				// 버퍼에 저장된 내용을 불러와 파일을 생성하는 스트림
				using (FileStream toStream = new FileStream(ToPath, FileMode.Create))
				{
					byte[] buffer = new byte[1024 * 1024];
					int nRead = 0;

					// fromStream.Read로 파일을 읽어 buffer에 저장
					while ((nRead = fromStream.Read(buffer, 0, buffer.Length)) != 0)
					{
						// toStream.Write를 이용해 buffer에 저장된 데이터를 새로운 파일에 작성
						toStream.Write(buffer, 0, nRead);
						totalCopied += nRead;   // 한 세트 끝날때마다의 용량을 누적합산

						pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);
					}
				}
			}

			btnAsyncCopy.Enabled = true;
			return totalCopied;
		}
	}
}
