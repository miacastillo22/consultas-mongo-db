using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/lte")]
public class LteController: Controller {
    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        // Muestra todos los registros donde el costo sea menor o igual a 50000.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 50000);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno(){
        // Muestra los registros donde los metros_terreno sean menores o iguales a 500.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 500);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-baños")]
    public IActionResult ListarBaños(){
        // Muestra todos los registros donde los baños sean menor o igual a 1.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Baños, 1);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-metros-construccion")]
    public IActionResult ListarMetrosConstruccion(){
        // Muestra todos los registros donde los metros_construccion sean menor o igual a 50.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 50);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        // ) Muestra todos los registros donde los pisos sean menor o igual a 2.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}