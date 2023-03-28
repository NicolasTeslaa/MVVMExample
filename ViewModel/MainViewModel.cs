
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MVVMExample.ViewModel;
//o observable object já nos fornece a funcão de alterar propriedades (INotifyPropertyChanged)
public partial class MainViewModel : ObservableObject
    {
    public MainViewModel()
    {
        items = new ObservableCollection<string>();
    }


    ObservableCollection<string> items;
    [ObservableProperty]
    string text;

    [ICommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;
        items.Add(text);
        //limpa o text
        Text = string.Empty;
    }






    //o codigo abaixo seria necessário se não instalassemos o mvvm toolkit, porém como instalamos, podemos fazer da maneira acima 
    // string text;

    // public string Text
    // {
    //  get => text;
    //  set
    //      {
    //  text = value;
    //atualiza a entrada automaticamente
    //  OnPropertyChanged(nameof(Text));
    //}
    //}
    //propriedade que permite atualizar um valor de uma propriedade
    //  public event PropertyChangedEventHandler PropertyChanged;
    //  void OnPropertyChanged(string name) =>
    // PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
}

