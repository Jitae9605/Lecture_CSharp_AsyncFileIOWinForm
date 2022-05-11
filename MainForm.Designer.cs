
namespace AsyncFileIOWinForm
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblSource = new System.Windows.Forms.Label();
			this.lblTarget = new System.Windows.Forms.Label();
			this.btnAsyncCopy = new System.Windows.Forms.Button();
			this.btnSyncCopy = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pbCopy = new System.Windows.Forms.ProgressBar();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.btnFindSource = new System.Windows.Forms.Button();
			this.btnFindTarget = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(10, 30);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(53, 12);
			this.lblSource.TabIndex = 0;
			this.lblSource.Text = "Source :";
			// 
			// lblTarget
			// 
			this.lblTarget.AutoSize = true;
			this.lblTarget.Location = new System.Drawing.Point(12, 57);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(49, 12);
			this.lblTarget.TabIndex = 0;
			this.lblTarget.Text = "Target :";
			// 
			// btnAsyncCopy
			// 
			this.btnAsyncCopy.Location = new System.Drawing.Point(12, 83);
			this.btnAsyncCopy.Name = "btnAsyncCopy";
			this.btnAsyncCopy.Size = new System.Drawing.Size(97, 40);
			this.btnAsyncCopy.TabIndex = 1;
			this.btnAsyncCopy.Text = "Async Copy";
			this.btnAsyncCopy.UseVisualStyleBackColor = true;
			this.btnAsyncCopy.Click += new System.EventHandler(this.btnAsyncCopy_Click);
			// 
			// btnSyncCopy
			// 
			this.btnSyncCopy.Location = new System.Drawing.Point(115, 83);
			this.btnSyncCopy.Name = "btnSyncCopy";
			this.btnSyncCopy.Size = new System.Drawing.Size(103, 40);
			this.btnSyncCopy.TabIndex = 1;
			this.btnSyncCopy.Text = "Sync Copy";
			this.btnSyncCopy.UseVisualStyleBackColor = true;
			this.btnSyncCopy.Click += new System.EventHandler(this.btnSyncCopy_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(224, 83);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(103, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// pbCopy
			// 
			this.pbCopy.Location = new System.Drawing.Point(14, 132);
			this.pbCopy.Name = "pbCopy";
			this.pbCopy.Size = new System.Drawing.Size(315, 37);
			this.pbCopy.TabIndex = 2;
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(65, 25);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(224, 21);
			this.txtSource.TabIndex = 3;
			// 
			// txtTarget
			// 
			this.txtTarget.Location = new System.Drawing.Point(65, 54);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(224, 21);
			this.txtTarget.TabIndex = 3;
			// 
			// btnFindSource
			// 
			this.btnFindSource.Location = new System.Drawing.Point(295, 25);
			this.btnFindSource.Name = "btnFindSource";
			this.btnFindSource.Size = new System.Drawing.Size(32, 23);
			this.btnFindSource.TabIndex = 4;
			this.btnFindSource.Text = "...";
			this.btnFindSource.UseVisualStyleBackColor = true;
			this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
			// 
			// btnFindTarget
			// 
			this.btnFindTarget.Location = new System.Drawing.Point(295, 54);
			this.btnFindTarget.Name = "btnFindTarget";
			this.btnFindTarget.Size = new System.Drawing.Size(32, 23);
			this.btnFindTarget.TabIndex = 4;
			this.btnFindTarget.Text = "...";
			this.btnFindTarget.UseVisualStyleBackColor = true;
			this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 181);
			this.Controls.Add(this.btnFindTarget);
			this.Controls.Add(this.btnFindSource);
			this.Controls.Add(this.txtTarget);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.pbCopy);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSyncCopy);
			this.Controls.Add(this.btnAsyncCopy);
			this.Controls.Add(this.lblTarget);
			this.Controls.Add(this.lblSource);
			this.Name = "MainForm";
			this.Text = "Async File Copy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.Label lblTarget;
		private System.Windows.Forms.Button btnAsyncCopy;
		private System.Windows.Forms.Button btnSyncCopy;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ProgressBar pbCopy;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.Button btnFindSource;
		private System.Windows.Forms.Button btnFindTarget;
	}
}

