﻿namespace Winform_Custom_Controls.UserControls
{
    partial class CtrlColorizeButton
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Panel();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 48);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.btnColor_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.btnColor_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.btnColor_MouseLeave);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnColor_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(1, 1);
            this.btnColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 48);
            this.btnColor.TabIndex = 0;
            this.btnColor.UseVisualStyleBackColor = false;
            // 
            // border
            // 
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.btnColor);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(1);
            this.border.Size = new System.Drawing.Size(100, 50);
            this.border.TabIndex = 2;
            // 
            // ColorizeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.border);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColorizeButton";
            this.Size = new System.Drawing.Size(100, 50);
            this.Load += new System.EventHandler(this.usrButtonColor_Load);
            this.EnabledChanged += new System.EventHandler(this.usrButtonColor_EnabledChanged);
            this.border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel border;
    }
}
