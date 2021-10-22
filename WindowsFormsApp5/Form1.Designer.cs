
namespace WindowsFormsApp5
{
    partial class FlappyForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbPipe2 = new System.Windows.Forms.PictureBox();
            this.pbPipe4 = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbPipe1 = new System.Windows.Forms.PictureBox();
            this.pbPipe3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBird
            // 
            this.pbBird.Image = global::WindowsFormsApp5.Properties.Resources.birdnew;
            this.pbBird.Location = new System.Drawing.Point(12, 128);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(40, 32);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // pbPipe2
            // 
            this.pbPipe2.Image = global::WindowsFormsApp5.Properties.Resources.pipedown;
            this.pbPipe2.Location = new System.Drawing.Point(387, -1);
            this.pbPipe2.Name = "pbPipe2";
            this.pbPipe2.Size = new System.Drawing.Size(57, 83);
            this.pbPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe2.TabIndex = 1;
            this.pbPipe2.TabStop = false;
            // 
            // pbPipe4
            // 
            this.pbPipe4.Image = global::WindowsFormsApp5.Properties.Resources.pipedown;
            this.pbPipe4.Location = new System.Drawing.Point(580, -1);
            this.pbPipe4.Name = "pbPipe4";
            this.pbPipe4.Size = new System.Drawing.Size(60, 110);
            this.pbPipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe4.TabIndex = 2;
            this.pbPipe4.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbGround.Image = global::WindowsFormsApp5.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(0, 298);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(712, 108);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 3;
            this.pbGround.TabStop = false;
            this.pbGround.DockChanged += new System.EventHandler(this.bottom);
            // 
            // pbPipe1
            // 
            this.pbPipe1.Image = global::WindowsFormsApp5.Properties.Resources.pipe;
            this.pbPipe1.Location = new System.Drawing.Point(387, 202);
            this.pbPipe1.Name = "pbPipe1";
            this.pbPipe1.Size = new System.Drawing.Size(57, 95);
            this.pbPipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe1.TabIndex = 4;
            this.pbPipe1.TabStop = false;
            // 
            // pbPipe3
            // 
            this.pbPipe3.Image = global::WindowsFormsApp5.Properties.Resources.pipe;
            this.pbPipe3.Location = new System.Drawing.Point(581, 232);
            this.pbPipe3.Name = "pbPipe3";
            this.pbPipe3.Size = new System.Drawing.Size(59, 65);
            this.pbPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPipe3.TabIndex = 5;
            this.pbPipe3.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(7, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 32);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: ";
            // 
            // tmrGame
            // 
            this.tmrGame.Enabled = true;
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // FlappyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 406);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbPipe3);
            this.Controls.Add(this.pbPipe1);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbPipe4);
            this.Controls.Add(this.pbPipe2);
            this.Controls.Add(this.pbBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FlappyForm";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipe3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbPipe2;
        private System.Windows.Forms.PictureBox pbPipe4;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipe1;
        private System.Windows.Forms.PictureBox pbPipe3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
    }
}

