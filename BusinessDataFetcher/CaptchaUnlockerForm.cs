﻿namespace BusinessDataFetcher.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class CaptchaUnlockerForm : Form
    {
        #region Constructors

        public CaptchaUnlockerForm()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        private void CaptchUnlocker_Loaded(object sender, EventArgs e)
        {
            MessageBox.Show("Aby kontynuować używanie programu:\n1. Przepisz Kod z obrazka\n2. Kliknij OK, i zamknij okno przeglądarki", "Dostęp został zablokowany");
        }

        #endregion Methods
    }
}