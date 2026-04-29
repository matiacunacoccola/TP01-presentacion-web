public class Integrante
{
    public int DNI;
    public string Nombre;
    public DateTime FechaNacimiento;
    public List<string> Familiares;
    public List<string> Intereses;
    public string Foto { get; set; }

    public Integrante(int dni, string nombre, DateTime fecha, string foto, List<string> familiares, List<string> intereses)
    {
        DNI = dni;
        Nombre = nombre;
        FechaNacimiento=fecha;
        Foto=foto;
        Familiares=familiares;
        Intereses=intereses;
}
}