using _420DA3_07451_Projet_Initial.DataAccess.DTOs.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DTOs;
public class Utilisateur : AbstractDTO<int> {

    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public int? EntrepotDeTravailId { get; set; }
    public DateTime DateCreated { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    public Entrepot EntrepotDeTravail { get; set; } = null!;
    public List<Role> Roles { get; set; } = null!;


    public Utilisateur() : base() { }

    public Utilisateur(string username, string passwordHash) : base() {
        this.Username = username;
        this.PasswordHash = passwordHash;
    }

    public Utilisateur(string username, string passwordHash, int? entrepotDeTravailId)
        : this(username, passwordHash) {
        this.EntrepotDeTravailId = entrepotDeTravailId;
    }

    protected Utilisateur(int id, string username, string passwordHash, int? entrepotDeTravailId, DateTime dateCreated, byte[] rowVersion)
        : this(username, passwordHash, entrepotDeTravailId) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.RowVersion = rowVersion;
    }
}
