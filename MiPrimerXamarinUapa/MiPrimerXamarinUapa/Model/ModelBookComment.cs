using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace Bookeeper.Model
{
    public class ModelBookComment : INotifyPropertyChanged
    {
        private int bookId;
        private string bookComment;
        //private DateTime dateAdded;

        // Maneja los eventos cuando se actualicen las propiedades
        public event PropertyChangedEventHandler PropertyChanged;

        // Evento que va a verificar el cambio de la propiedad
        protected virtual void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));

            }
        }

        public int BookId
        {
            get
            {
                return bookId;
            }

            set
            {
                if (bookId != value)
                {
                    bookId = value;
                    OnPropertyChanged("bookId");
                }
            }
        }

        public string BookComment
        {
            get
            {
                return bookComment;
            }

            set
            {
                if (bookComment != value)
                {
                    bookComment = value;
                    OnPropertyChanged("bookComment");
                }
            }
        }

        /*public DateTime DateAdded
        {
            get
            {
                return dateAdded;
            }

            set
            {
                if (dateAdded != value)
                {
                    dateAdded = value;
                    OnPropertyChanged("dateAdded");
                }
            }
        }*/
    }
}
