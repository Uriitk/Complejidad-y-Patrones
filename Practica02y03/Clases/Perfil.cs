public abstract class Perfil : Comparable {
    protected string nombre;
    protected int id;
    public Perfil(string n, int i) {
        nombre = n;
        id = i;
    }
    public string getNombre() {
        return nombre;
    }
    public int getId() {
        return id;
    }
    public virtual bool sosIgual(Comparable c) {
        return id == ((Perfil)c).getId();
    }
    public virtual bool sosMenor(Comparable c) {
        return id < ((Perfil)c).getId();
    }
    public virtual bool sosMayor(Comparable c) {
        return id > ((Perfil)c).getId();
    }
    public override string ToString() {
        return "[Perfil: Nombre=" + nombre + ", ID=" + id + "]";
    }
}