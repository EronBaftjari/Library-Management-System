namespace LibrarySYS
{
    partial class frmMemberJoinRateReport
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
            this.lblJoinRates = new System.Windows.Forms.Label();
            this.btnAnylise = new System.Windows.Forms.Button();
            this.chtMemberJoinRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboMemberJoinRate = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chtMemberJoinRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitNav
            // 
            this.btnExitNav.Location = new System.Drawing.Point(12, 23);
            this.btnExitNav.Name = "btnExitNav";
            this.btnExitNav.Size = new System.Drawing.Size(97, 30);
            this.btnExitNav.TabIndex = 16;
            this.btnExitNav.Text = "Exit";
            this.btnExitNav.UseVisualStyleBackColor = true;
            this.btnExitNav.Click += new System.EventHandler(this.btnExitNav_Click);
            // 
            // lblJoinRates
            // 
            this.lblJoinRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinRates.Location = new System.Drawing.Point(147, 23);
            this.lblJoinRates.Name = "lblJoinRates";
            this.lblJoinRates.Size = new System.Drawing.Size(578, 35);
            this.lblJoinRates.TabIndex = 18;
            this.lblJoinRates.Text = "Choose Date to Show Member Joins Anylysis";
            // 
            // btnAnylise
            // 
            this.btnAnylise.Location = new System.Drawing.Point(315, 131);
            this.btnAnylise.Name = "btnAnylise";
            this.btnAnylise.Size = new System.Drawing.Size(127, 38);
            this.btnAnylise.TabIndex = 19;
            this.btnAnylise.Text = "Anylys Data";
            this.btnAnylise.UseVisualStyleBackColor = true;
            this.btnAnylise.Click += new System.EventHandler(this.btnAnylise_Click);
            // 
            // chtMemberJoinRate
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMemberJoinRate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMemberJoinRate.Legends.Add(legend1);
            this.chtMemberJoinRate.Location = new System.Drawing.Point(119, 213);
            this.chtMemberJoinRate.Name = "chtMemberJoinRate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMemberJoinRate.Series.Add(series1);
            this.chtMemberJoinRate.Size = new System.Drawing.Size(746, 341);
            this.chtMemberJoinRate.TabIndex = 20;
            this.chtMemberJoinRate.Text = "chart1";
            // 
            // cboMemberJoinRate
            // 
            this.cboMemberJoinRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMemberJoinRate.FormattingEnabled = true;
            this.cboMemberJoinRate.Location = new System.Drawing.Point(297, 75);
            this.cboMemberJoinRate.Name = "cboMemberJoinRate";
            this.cboMemberJoinRate.Size = new System.Drawing.Size(186, 21);
            this.cboMemberJoinRate.TabIndex = 44;
            // 
            // frmMemberJoinRateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 623);
            this.Controls.Add(this.cboMemberJoinRate);
            this.Controls.Add(this.chtMemberJoinRate);
            this.Controls.Add(this.btnAnylise);
            this.Controls.Add(this.lblJoinRates);
            this.Controls.Add(this.btnExitNav);
            this.Name = "frmMemberJoinRateReport";
            this.Text = "frmMemberJoinRateReport";
            this.Load += new System.EventHandler(this.frmMemberJoinRateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtMemberJoinRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitNav;
        private System.Windows.Forms.Label lblJoinRates;
        private System.Windows.Forms.Button btnAnylise;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMemberJoinRate;
        private System.Windows.Forms.ComboBox cboMemberJoinRate;
    }
}