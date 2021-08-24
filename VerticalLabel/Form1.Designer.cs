
namespace VerticalLabel
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.customVerticalLabel1 = new VerticalLabel.CustomVerticalLabel();
            this.customVerticalLabel2 = new VerticalLabel.CustomVerticalLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.5F));
            this.tableLayoutPanel1.Controls.Add(this.customVerticalLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.customVerticalLabel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // customVerticalLabel1
            // 
            this.customVerticalLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customVerticalLabel1.Location = new System.Drawing.Point(3, 3);
            this.customVerticalLabel1.Name = "customVerticalLabel1";
            this.customVerticalLabel1.Size = new System.Drawing.Size(166, 219);
            this.customVerticalLabel1.TabIndex = 0;
            this.customVerticalLabel1.VerticalLabelText = "FLOW";
            // 
            // customVerticalLabel2
            // 
            this.customVerticalLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customVerticalLabel2.Location = new System.Drawing.Point(3, 228);
            this.customVerticalLabel2.Name = "customVerticalLabel2";
            this.customVerticalLabel2.Size = new System.Drawing.Size(166, 219);
            this.customVerticalLabel2.TabIndex = 1;
            this.customVerticalLabel2.VerticalLabelText = "POWER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomVerticalLabel customVerticalLabel1;
        private CustomVerticalLabel customVerticalLabel2;
    }
}

