
namespace Contact_Tracing_App
{
    partial class frmReadVisitors
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtVisitorsRead = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(32, 13);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(162, 38);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = " View Visitor\'s List";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(518, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = ">";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtVisitorsRead
            // 
            this.txtVisitorsRead.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVisitorsRead.Location = new System.Drawing.Point(32, 57);
            this.txtVisitorsRead.Multiline = true;
            this.txtVisitorsRead.Name = "txtVisitorsRead";
            this.txtVisitorsRead.ReadOnly = true;
            this.txtVisitorsRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisitorsRead.Size = new System.Drawing.Size(529, 460);
            this.txtVisitorsRead.TabIndex = 3;
            // 
            // frmReadVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(589, 538);
            this.Controls.Add(this.txtVisitorsRead);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRead);
            this.Name = "frmReadVisitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitors ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtVisitorsRead;
    }
}