namespace Playnary
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.challenge = new System.Windows.Forms.Label();
            this.binary = new System.Windows.Forms.TextBox();
            this.bits = new System.Windows.Forms.HScrollBar();
            this.mode = new System.Windows.Forms.Label();
            this.bases = new System.Windows.Forms.HScrollBar();
            this.baseMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(56, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(14, 13);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            // 
            // challenge
            // 
            this.challenge.BackColor = System.Drawing.Color.Transparent;
            this.challenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challenge.ForeColor = System.Drawing.Color.White;
            this.challenge.Location = new System.Drawing.Point(12, 22);
            this.challenge.Name = "challenge";
            this.challenge.Size = new System.Drawing.Size(260, 68);
            this.challenge.TabIndex = 2;
            this.challenge.Text = "0";
            this.challenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binary
            // 
            this.binary.BackColor = System.Drawing.Color.Black;
            this.binary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.binary.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binary.ForeColor = System.Drawing.Color.Lime;
            this.binary.Location = new System.Drawing.Point(12, 103);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(260, 24);
            this.binary.TabIndex = 3;
            this.binary.Text = "0";
            this.binary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.binary.TextChanged += new System.EventHandler(this.binary_TextChanged);
            // 
            // bits
            // 
            this.bits.LargeChange = 2;
            this.bits.Location = new System.Drawing.Point(12, 130);
            this.bits.Maximum = 9;
            this.bits.Minimum = 1;
            this.bits.Name = "bits";
            this.bits.Size = new System.Drawing.Size(127, 18);
            this.bits.TabIndex = 4;
            this.bits.Value = 4;
            this.bits.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bits_Scroll);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode.ForeColor = System.Drawing.Color.Black;
            this.mode.Location = new System.Drawing.Point(12, 152);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(127, 22);
            this.mode.TabIndex = 5;
            this.mode.Text = "BIT MODE: 4";
            this.mode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bases
            // 
            this.bases.LargeChange = 2;
            this.bases.Location = new System.Drawing.Point(145, 130);
            this.bases.Maximum = 64;
            this.bases.Minimum = 1;
            this.bases.Name = "bases";
            this.bases.Size = new System.Drawing.Size(127, 18);
            this.bases.TabIndex = 6;
            this.bases.Value = 4;
            this.bases.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bases_Scroll);
            // 
            // baseMode
            // 
            this.baseMode.BackColor = System.Drawing.Color.Transparent;
            this.baseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseMode.ForeColor = System.Drawing.Color.Black;
            this.baseMode.Location = new System.Drawing.Point(145, 152);
            this.baseMode.Name = "baseMode";
            this.baseMode.Size = new System.Drawing.Size(127, 22);
            this.baseMode.TabIndex = 7;
            this.baseMode.Text = "BASE: 2";
            this.baseMode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Playnary.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(284, 183);
            this.Controls.Add(this.baseMode);
            this.Controls.Add(this.bases);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.bits);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.challenge);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Playnary";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label challenge;
        private System.Windows.Forms.TextBox binary;
        private System.Windows.Forms.HScrollBar bits;
        private System.Windows.Forms.Label mode;
        private System.Windows.Forms.HScrollBar bases;
        private System.Windows.Forms.Label baseMode;
    }
}

