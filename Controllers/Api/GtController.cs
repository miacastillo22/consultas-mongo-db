using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/gt")]
public class GtController: Controller {
    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //Listar todo los registros donde el costo sea menor o igual a 50000.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 50000);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    
    [HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno(){
        //Listar todo los registros donde los metros_terreno sean mayores a 600.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosTerreno, 600);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-metros-construccion")]
    public IActionResult ListarMetrosConstruccion(){
        //Listar todo los registros donde los metros_construccion sean mayores a 100.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosConstruccion, 100);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

     [HttpGet("listar-baños")]
    public IActionResult ListarBaños(){
        //Listar todo los registros donde los baños sean mayores a 1.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Baños, 1);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    
     [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        //Listar todo los registrosdonde los pisos sean mayores a 2.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

 }