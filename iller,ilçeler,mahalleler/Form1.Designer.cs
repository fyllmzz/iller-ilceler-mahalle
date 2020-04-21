namespace iller_ilçeler_mahalleler
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
			this.components = new System.ComponentModel.Container();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ds_tabloilişkilendirme = new iller_ilçeler_mahalleler.ds_tabloilişkilendirme();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.fKilçelerillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.fKmahallelerilçelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.illerTableAdapter = new iller_ilçeler_mahalleler.ds_tabloilişkilendirmeTableAdapters.illerTableAdapter();
			this.ilçelerTableAdapter = new iller_ilçeler_mahalleler.ds_tabloilişkilendirmeTableAdapters.ilçelerTableAdapter();
			this.mahallelerTableAdapter = new iller_ilçeler_mahalleler.ds_tabloilişkilendirmeTableAdapters.mahallelerTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_tabloilişkilendirme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKilçelerillerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKmahallelerilçelerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.illerBindingSource;
			this.comboBox1.DisplayMember = "il";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(235, 67);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// illerBindingSource
			// 
			this.illerBindingSource.DataMember = "iller";
			this.illerBindingSource.DataSource = this.ds_tabloilişkilendirme;
			// 
			// ds_tabloilişkilendirme
			// 
			this.ds_tabloilişkilendirme.DataSetName = "ds_tabloilişkilendirme";
			this.ds_tabloilişkilendirme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.fKilçelerillerBindingSource;
			this.comboBox2.DisplayMember = "ilçe";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(235, 120);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			// 
			// fKilçelerillerBindingSource
			// 
			this.fKilçelerillerBindingSource.DataMember = "FK_ilçeler_iller";
			this.fKilçelerillerBindingSource.DataSource = this.illerBindingSource;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.fKmahallelerilçelerBindingSource;
			this.comboBox3.DisplayMember = "mahalle";
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(235, 173);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 2;
			// 
			// fKmahallelerilçelerBindingSource
			// 
			this.fKmahallelerilçelerBindingSource.DataMember = "FK_mahalleler_ilçeler";
			this.fKmahallelerilçelerBindingSource.DataSource = this.fKilçelerillerBindingSource;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(137, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "İLLER";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(115, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "İLÇELER";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(74, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "MAHALLELER";
			// 
			// illerTableAdapter
			// 
			this.illerTableAdapter.ClearBeforeFill = true;
			// 
			// ilçelerTableAdapter
			// 
			this.ilçelerTableAdapter.ClearBeforeFill = true;
			// 
			// mahallelerTableAdapter
			// 
			this.mahallelerTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(455, 268);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tablo İlişkilendirme Sayfası";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ds_tabloilişkilendirme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKilçelerillerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKmahallelerilçelerBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private ds_tabloilişkilendirme ds_tabloilişkilendirme;
		private System.Windows.Forms.BindingSource illerBindingSource;
		private ds_tabloilişkilendirmeTableAdapters.illerTableAdapter illerTableAdapter;
		private System.Windows.Forms.BindingSource fKilçelerillerBindingSource;
		private ds_tabloilişkilendirmeTableAdapters.ilçelerTableAdapter ilçelerTableAdapter;
		private System.Windows.Forms.BindingSource fKmahallelerilçelerBindingSource;
		private ds_tabloilişkilendirmeTableAdapters.mahallelerTableAdapter mahallelerTableAdapter;
	}
}

