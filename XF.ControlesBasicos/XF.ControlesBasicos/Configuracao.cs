using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XF.ControlesBasicos
{
        public class Configuracao : INotifyPropertyChanged
        {
            public Configuracao()
            {
                receberEmail = false;
                EnderecoEmail = "";
            }


            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged()
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EnderecoEmail"));
            }

            private bool receberEmail;
            public bool ReceberEmail
            {
                get => receberEmail;
                set
                {
                    if (receberEmail != value)
                    {
                        receberEmail = value;
                        if (!receberEmail)
                            EnderecoEmail = "";

                        OnPropertyChanged();
                    }
                }
            }
            public string EnderecoEmail { get; set; }
        }
    }
