﻿using _420DA3_07451_Projet_Initial.DataAccess.Contexts.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DAOs.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.DataAccess.DAOs;
public class FournisseurDAO : AbstractDao<Fournisseur, int> {

    protected override AbstractContext Context { get; }

    public FournisseurDAO (AbstractContext context) {
        this.Context = context;
    }

    public override Fournisseur? GetById(int identifier) {
        return this.Context.GetDbSet<Fournisseur>()
            .Where(user => user.Id == identifier)
            .Include(user => user.AdresseId)
            .Include(user => user.ContactId)
            .Include(user => user.SupplierName)
            .SingleOrDefault();
    }


    public override List<Fournisseur> GetAll() {
        return this.Context.GetDbSet<Fournisseur>()
            .Include(user => user.AdresseId)
            .ToList();
    }

    public Fournisseur? GetByAdressId(int adresseId) {
        return this.Context.GetDbSet<Fournisseur>()
            .Where(user => user.AdresseId == adresseId)
            .Include(user => user.AdresseId)
            .Include(user => user.ContactId)
            .Include(user => user.SupplierName)
            .SingleOrDefault();
    }




}