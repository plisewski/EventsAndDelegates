using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class Book
    {
        private string _name;

        public event NameChangedDelegate NameChanged;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // as _name change occurs here, this the place where the event is invoked

                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }
    }
}
