using Microsoft.EntityFrameworkCore.ChangeTracking;
using model.modelEF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dao
{
    public class MutantDAO
    {

        /**
         * Consulta que permite traer la información de una secuencia si esta
         * ya fue analizada
         * @param dna - Secuencia de ADN a consultar
         * @return lista de secuencias en la base de datos
         */

        public List<Mutant> findByDna(string dna)
        {
            List<Mutant> liMutant = new List<Mutant>();
            using (dbmutantContext db = new dbmutantContext())
            {
                liMutant = db.Mutant
                    .Where(i => i.Dna == dna)
                    .ToList();
            }
            return liMutant;
        }

        public List<Mutant> findAll()
        {
            List<Mutant> liMutant = new List<Mutant>();
            using (dbmutantContext db = new dbmutantContext())
            {
                liMutant = db.Mutant
                    .ToList();
            }
            return liMutant;
        }

        public Mutant save(Mutant model)
        {
            try
            {
                using (dbmutantContext db = new dbmutantContext())
                {
                    EntityEntry<Mutant> modelInsert = db.Mutant.Add(model);
                    db.SaveChanges();
                    return modelInsert.Entity;
                }
            }
            catch (Exception ex)
            {
                return model;
            }
        }
    }
}