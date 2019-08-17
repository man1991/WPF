using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;

namespace WPF_Commands_INotifyPropertyChangedInterface
{
    public class MyCounter : INotifyPropertyChanged
    {
        //MyCounter class object will be created by WPF UI.
        private int _Counter;
        private CommandCounter myCommand;
        public MyCounter()
        {
            myCommand = new CommandCounter(this);//passing current instance of MyCounter class to CommandCounter so that it can 
                                                 //invoke Increment() method
        }
        //need to expose the CommandCounter class to the external world so that WPF UI can bind itself
        public ICommand CommandCounterAction // Command (Action) -- btn click, key down will get binded
        {
            get
            {
                return myCommand;
            }
        }
        public int Counter //textbox property will be binded, (Bindings)
        {
            get { return _Counter; }
            set { _Counter = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Increment()
        {
            _Counter++;
            PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
        }
    }

    //CommandCounter will wrap all the code which is needed to increment the counter
    //ICommand interface lies in System.Windows.Input namespace
    public class CommandCounter : ICommand
    {
        //As we want to implement Increment() method of MyCounter class we need to have instance/object of MyCounter class.
        //MyCounter instance should be that instance which will be created by WPF UI objects.
        //Creating our own is of no use e.g. private MyCounter obj = new MyCounter();

        private MyCounter obj;//WPF UI
        public CommandCounter(MyCounter o) //WPF MyCounter instance 
        {
            obj = o;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) //When to execute
        {
            return true;
        }

        public void Execute(object parameter) //What do we want to execute
        {
            obj.Increment();
        }
    }
}
