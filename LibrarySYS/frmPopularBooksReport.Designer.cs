
namespace LibrarySYS
{
    partial class frmPopularBooksReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnExitNav = new System.Windows.Forms.Button();
            this.lblPopularBooks = new System.Windows.Forms.Label();
            this.btnShowPopularBooks = new System.Windows.Forms.Button();
            this.cboPopularBooksYear = new System.Windows.Forms.ComboBox();
            this.chtPopularBooksAnylysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtPopularBooksAnylysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 12);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(111, 30);
            this.btnExitNav.TabIndex = 23;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // lblPopularBooks
            // 
            this.lblPopularBooks.AutoSize = true;
            this.lblPopularBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPopularBooks.Location = new System.Drawing.Point(307, 41);
            this.lblPopularBooks.Name = "lblPopularBooks";
            this.lblPopularBooks.Size = new System.Drawing.Size(279, 62);
            this.lblPopularBooks.TabIndex = 24;
            this.lblPopularBooks.Text = "Popular Books Report\r\nClick here to See\r\n";
            // 
            // btnShowPopularBooks
            // 
            this.btnShowPopularBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPopularBooks.Location = new System.Drawing.Point(274, 184);
            this.btnShowPopularBooks.Name = "btnShowPopularBooks";
            this.btnShowPopularBooks.Size = new System.Drawing.Size(277, 38);
            this.btnShowPopularBooks.TabIndex = 41;
            this.btnShowPopularBooks.Text = "Show Popular Books";
            this.btnShowPopularBooks.UseVisualStyleBackColor = true;
            this.btnShowPopularBooks.Click += new System.EventHandler(this.btnShowPopularBooks_Click);
            // 
            // cboPopularBooksYear
            // 
            this.cboPopularBooksYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPopularBooksYear.FormattingEnabled = true;
            this.cboPopularBooksYear.Location = new System.Drawing.Point(313, 132);
            this.cboPopularBooksYear.Name = "cboPopularBooksYear";
            this.cboPopularBooksYear.Size = new System.Drawing.Size(186, 21);
            this.cboPopularBooksYear.TabIndex = 43;
            // 
            // chtPopularBooksAnylysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtPopularBooksAnylysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtPopularBooksAnylysis.Legends.Add(legend1);
            this.chtPopularBooksAnylysis.Location = new System.Drawing.Point(128, 248);
            this.chtPopularBooksAnylysis.Name = "chtPopularBooksAnylysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtPopularBooksAnylysis.Series.Add(series1);
            this.chtPopularBooksAnylysis.Size = new System.Drawing.Size(650, 293);
            this.chtPopularBooksAnylysis.TabIndex = 44;
            this.chtPopularBooksAnylysis.Text = "chart1";
            // 
            // frmPopularBooksReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 673);
            this.Controls.Add(this.chtPopularBooksAnylysis);
            this.Controls.Add(this.cboPopularBooksYear);
            this.Controls.Add(this.btnShowPopularBooks);
            this.Controls.Add(this.lblPopularBooks);
            this.Controls.Add(this.btnExitNav);
            this.Name = "frmPopularBooksReport";
            this.Text = "frmPopularBooksReport";
            this.Load += new System.EventHandler(this.frmPopularBooksReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtPopularBooksAnylysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.Label lblPopularBooks;
        private System.Windows.Forms.Button btnShowPopularBooks;
        private System.Windows.Forms.ComboBox cboPopularBooksYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtPopularBooksAnylysis;
    }
}