using System;
using MoneyChangeAPI.DataAccess;
using MoneyChangeAPI.Entities;
using MoneyChangeAPI.Models;

namespace MoneyChangeAPI.BussinesLogic;

public class MetaBL
{
    private readonly MetaDA metaDA;
    public MetaBL(IConfiguration configuration)
    {
        metaDA = new MetaDA(configuration.GetConnectionString("dbMoneyControl"));
    }

    public MetaEntity BuscarPorId(int id_meta){
        try
        {
            return metaDA.BuscarPorId(id_meta);   
        }
        catch (Exception)
        {
            throw;
        }        
    }

    public IEnumerable<MetaItemModel> ListarPorUsuario(string id_usuario){
        try
        {
            return metaDA.ListarPorUsuario(id_usuario);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public int Registrar(MetaEntity metaEntity){
        try
        {
            return metaDA.Registrar(metaEntity);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public bool Modificar(MetaEntity metaEntity){
        try
        {
            return metaDA.Modificar(metaEntity);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public bool Eliminar(int id_meta){
        try
        {
            return metaDA.Eliminar(id_meta);
        }
        catch (Exception)
        {
            throw;
        }
    }
}
