﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaMedica.Helpers {
    class ExceptionsHelper {
        private Exception erro;
        private string message;

        public ExceptionsHelper(Exception e, string message) {
            this.erro = e;
            this.message = message;
        }

        public void lancaException() {
            Console.WriteLine(this.erro);
            MessageBox.Show(this.message);
        }
    }
}
