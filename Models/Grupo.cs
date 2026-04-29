public class Grupo
{
    public Dictionary<int, Integrante> Integrantes;

    public Grupo()
    {
        Integrantes = new Dictionary<int, Integrante>();
        Cargar();
    }

    public void Cargar()
    {
        Integrante i1 = new Integrante(
            11111111,
            "Thiago",
            new DateTime(2009, 1, 1),
            "Thiago.jpg",
            new List<string> { "Papa: Carlos", "Mama: Laura" },
            new List<string> { "Futbol", "Series" }
        );

        Integrante i2 = new Integrante(
            22222222,
            "Matias",
            new DateTime(2010, 2, 2),
            "matias.jpg",
            new List<string> { "Papa: Diego", "Mama: Ana" },
            new List<string> { "Futbol", "Videojuegos" }
        );

        Integrantes.Add(i1.DNI, i1);
        Integrantes.Add(i2.DNI, i2);
    }

    public Dictionary<int, Integrante> Devolver()
    {
        return Integrantes;
    }

    public Integrante Buscar(int dni)
    {
        if (Integrantes.ContainsKey(dni))
            return Integrantes[dni];
        else
            return null;
    }
}