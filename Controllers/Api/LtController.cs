using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/lt")]
public class LtController: Controller {
    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //Muestra todos los registros donde el costo sea menor a 30000.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 30000);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
      [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        // Muestra todos los registros donde los pisos sean menores a 2.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
     [HttpGet("listar-metros-construccion")]
    public IActionResult ListarMetrosConstruccion(){
        // Muestra todos los registros donde los metros_construccion sean menores a 100.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 100);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
     [HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno(){
        // Muestra todos los registros donde los metros_terreno sean menores a 500.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 500);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
     [HttpGet("listar-costo2")]
    public IActionResult ListarCosto2(){
        // ) Muestra los registros donde el costo sea menor a 20,000.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 20000);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}