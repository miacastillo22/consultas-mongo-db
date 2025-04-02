using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/gte")]
public class GteController: Controller {
    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //Listar todo los registros donde el costo sea mayor o igual a 40000.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 40000);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

     [HttpGet("listar-baños")]
    public IActionResult ListarBaños(){
        //Listar todo los registros donde los baños sean mayor o igual a 1.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Baños, 1);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
     [HttpGet("listar-metros-construccion")]
    public IActionResult ListarMetrosConstruccion(){
        //Listar todo los registros donde los metros_construccion sean mayor o igual a 50.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 50);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

     [HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno(){
        //Listar todo los registros registros donde los metros_terreno sean mayor o igual a 518.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 518);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
     [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        //Listar todo los registros donde los pisos sean mayores o iguales a 3.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 3);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}