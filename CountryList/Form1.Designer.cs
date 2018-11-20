namespace CountryList
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCountry = new System.Windows.Forms.ListBox();
            this.lbCity = new System.Windows.Forms.ListBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.btInput = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCountry
            // 
            this.lbCountry.FormattingEnabled = true;
            this.lbCountry.Location = new System.Drawing.Point(12, 12);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(280, 238);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.SelectedIndexChanged += new System.EventHandler(this.lbCountry_SelectedIndexChanged);
            // 
            // lbCity
            // 
            this.lbCity.FormattingEnabled = true;
            this.lbCity.Location = new System.Drawing.Point(508, 12);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(280, 238);
            this.lbCity.TabIndex = 1;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(12, 279);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(280, 20);
            this.tbCountry.TabIndex = 2;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(508, 279);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(280, 20);
            this.tbCity.TabIndex = 3;
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(115, 346);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(90, 40);
            this.btInput.TabIndex = 4;
            this.btInput.Text = "Ajout";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(366, 346);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(90, 40);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Supprimer";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(623, 346);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(90, 40);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Sauvegarder";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInput);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCountry;
        private System.Windows.Forms.ListBox lbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
    }
}

