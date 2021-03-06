﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace Group11_Assignment1.Models
{
    public class DebitersCreditors : BindableBase
    {
        private string name;
        private Double amount;
        
        public DebitersCreditors(string name, Double amount)
        {
            name = this.name;
            amount = this.amount;
        }

        public DebitersCreditors()
        {
        }

        public DebitersCreditors Clone()
        {
            return this.MemberwiseClone() as DebitersCreditors;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                SetProperty(ref name, value);
            }
        }

        public Double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                SetProperty(ref amount, value);
            }
        }
    }
}
