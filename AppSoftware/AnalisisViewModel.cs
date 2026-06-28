using System.ComponentModel;
using System.Windows.Input;

namespace AppSoftware.ViewModels;

public class AnalisisViewModel : INotifyPropertyChanged
{
    private string _resultado;
    public string TextoUsuario { get; set; }
    
    public string Resultado 
    { 
        get => _resultado; 
        set { _resultado = value; OnPropertyChanged(nameof(Resultado)); } 
    }

    public ICommand AnalizarCommand { get; }

    public AnalisisViewModel()
    {
        AnalizarCommand = new Command(EjecutarAnalisisIA);
    }

    private void EjecutarAnalisisIA()
    {
        // Simulación de tecnología disruptiva (IA)
        Resultado = $"Procesando '{TextoUsuario}' con motor de IA... Éxito.";
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
