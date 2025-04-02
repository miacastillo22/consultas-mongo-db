using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/eq")]
public class EqController: Controller {
    [HttpGet("listar-terreno")]
    public IActionResult ListarTerreno(){
        //Listar todo los registros donde el tipo sea Terreno
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Terreno");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-nombre-agente")]
    public IActionResult ListarNombreAgente(){
        //Listar todo los registros donde el nombre agente sea Ana Torres
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente, "Ana Torres");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-tiene-patio")]
    public IActionResult ListarTienePatio(){
        //Listar todo los registros donde el tiene patio sea false
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.TienePatio, false);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia(){
        //Listar todo los registros donde la agencia sea "Inmobiliaria Pérez".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Agencia, "Inmobiliaria Pérez");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //Listar todo los registros donde el costo sea 33421
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x => x.Costo, 33421);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}