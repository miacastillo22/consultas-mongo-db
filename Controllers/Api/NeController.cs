using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/ne")]
public class NeController: Controller {
    [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(){
        // Muestra todos los registros donde el tipo no sea "Departamento".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Departamento");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-nombre-agente")]
    public IActionResult ListarNombreAgente(){
        // Muestra todos los registros donde el nombre_agente no sea "Ana Torres".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "Ana Torres");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-tiene-patio")]
    public IActionResult ListarTienePatio(){
        //Muestra todos los registros donde el tiene_patio no sea true.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.TienePatio, true);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia(){
        //Muestra todos los registros donde la agencia no sea "Inmobiliaria Pérez".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria Pérez");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-costo")]
    public IActionResult ListarCosto(){
        //Muestra todos los registros donde el costo no sea 33421.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 33421);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}