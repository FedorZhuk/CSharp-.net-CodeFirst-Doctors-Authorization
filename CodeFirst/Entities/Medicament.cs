namespace Cwiczenia9.Entities;

public class Medicament
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public virtual ICollection<Prescription_Medicament>? PrescriptionMedicaments { get; set; } =
        new List<Prescription_Medicament>();
}