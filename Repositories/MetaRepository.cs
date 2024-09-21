using System;
using MoneyChangeAPI.Models;

namespace MoneyChangeAPI.Repositories;

public interface MetaRepository
{
    IEnumerable<MetaItemModel> ListarPorUsuario(string id_usuario);
}
