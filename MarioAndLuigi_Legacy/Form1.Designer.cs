
namespace MarioAndLuigi_Legacy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.radioButtonLuigi = new System.Windows.Forms.RadioButton();
            this.radioButtonMario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(12, 34);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(625, 246);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(137, 286);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(119, 36);
            this.buttonA.TabIndex = 4;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(12, 286);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(119, 36);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // radioButtonLuigi
            // 
            this.radioButtonLuigi.AutoSize = true;
            this.radioButtonLuigi.Location = new System.Drawing.Point(78, 12);
            this.radioButtonLuigi.Name = "radioButtonLuigi";
            this.radioButtonLuigi.Size = new System.Drawing.Size(47, 16);
            this.radioButtonLuigi.TabIndex = 6;
            this.radioButtonLuigi.Text = "Luigi";
            this.radioButtonLuigi.UseVisualStyleBackColor = true;
            // 
            // radioButtonMario
            // 
            this.radioButtonMario.AutoSize = true;
            this.radioButtonMario.Checked = true;
            this.radioButtonMario.Location = new System.Drawing.Point(12, 12);
            this.radioButtonMario.Name = "radioButtonMario";
            this.radioButtonMario.Size = new System.Drawing.Size(51, 16);
            this.radioButtonMario.TabIndex = 5;
            this.radioButtonMario.TabStop = true;
            this.radioButtonMario.Text = "Mario";
            this.radioButtonMario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 336);
            this.Controls.Add(this.radioButtonLuigi);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.radioButtonMario);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.RadioButton radioButtonLuigi;
        private System.Windows.Forms.RadioButton radioButtonMario;
    }
}

