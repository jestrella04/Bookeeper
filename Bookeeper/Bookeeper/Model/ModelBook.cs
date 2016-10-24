using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace Bookeeper.Model
{
    public class ModelBook : INotifyPropertyChanged
    {
        private int bookId;
        private string bookTitle;
        private string bookAuthor;
        private int bookStatus;
        //private DateTime dateAdded;
        //private DateTime dateRead;

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

        [PrimaryKey, AutoIncrement]
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

        public string BookTitle
        {
            get
            {
                return bookTitle;
            }

            set
            {
                if (bookTitle != value)
                {
                    bookTitle = value;
                    OnPropertyChanged("bookTitle");
                }
            }
        }

        public string BookAuthor
        {
            get
            {
                return bookAuthor;
            }

            set
            {
                if (bookAuthor != value)
                {
                    bookAuthor = value;
                    OnPropertyChanged("bookAuthor");
                }
            }
        }

        public int BookStatus
        {
            get
            {
                return bookStatus;
            }

            set
            {
                if (bookStatus != value)
                {
                    bookStatus = value;
                    OnPropertyChanged("bookStatus");
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
        }

        public DateTime DateRead
        {
            get
            {
                return dateRead;
            }

            set
            {
                if (dateRead != value)
                {
                    dateRead = value;
                    OnPropertyChanged("dateReaf");
                }
            }
        }*/
    }
}
