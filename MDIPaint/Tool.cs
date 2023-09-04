using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MDIPaint
{
    public class Tool : INotifyPropertyChanged
    {
        private int brushWidth = 3;
        public int BrushWidth
        {
            get => brushWidth;
            set 
            {
                if (brushWidth != value)
                {
                    brushWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        private ToolType toolType = ToolType.Brush;
        public ToolType ToolType
        {
            get => toolType;
            set
            {
                if (toolType != value)
                {
                    toolType = value;
                    OnPropertyChanged();
                    if (toolType == ToolType.Eraser)
                    {
                        MainForm.TmpColor = MainForm.BrushColor;
                        MainForm.Flag = true;
                    }
                    else if(MainForm.Flag)
                    {
                        MainForm.BrushColor = MainForm.TmpColor;
                        MainForm.Flag = false;
                    }
                }
            }
        }

        private int verticesNumber = 5;
        public int VerticesNumber
        {
            get => verticesNumber;
            set 
            {
                if (verticesNumber != value)
                {
                    verticesNumber = value;
                    OnPropertyChanged();
                } 
            }
        }

        private void OnPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
