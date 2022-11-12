using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelesteAI.CelesteData
{
    public class ChapterObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        Chapters _chapter;

        public Chapters Chapter
        {
            get
            {
                return _chapter;
            }

            set
            {
                _chapter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Chapter)));
            }
        }
    }
}
