﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp1.Model
{
    public class PowerEntity
    {
        private long id;
        private string name;
        private double x;
        private double y; 

        public PowerEntity()
        {
            
        }

        virtual public Brush DefaultColor() {
            return Brushes.Black;
        } 
       
        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public override string ToString()
        {   
            return "ID: " + this.id + "\nName: " + this.name;
        }
    }
}
