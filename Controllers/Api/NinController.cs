using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/nin")]
public class NinController: Controller {
    [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(){
        //Muestra todos los registros donde el tipo no sea "Terreno" ni "Casa".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Terreno");
        tipo.Add ("Casa");
        
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Tipo, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
    [HttpGet("listar-agencia")]
    public IActionResult ListarAgencia(){
        //Muestra todos los registros donde la agencia no sea "Inmobiliaria Pérez" ni "Agencia XYZ".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Inmobiliaria Pérez");
        tipo.Add ("Agencia XYZ");
        
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }[HttpGet("listar-nombre-agente")]
    public IActionResult ListarNombreAgente(){
        //Muestra todos los registros donde el nombre_agente no sea "Ana Torres" ni "Carlos López".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Ana Torres");
        tipo.Add ("Carlos López");
        
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.NombreAgente, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }[HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        //Muestra todos los registros donde los pisos no sean 0, 1 ni 2.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <int> tipo = new List <int> ();
        tipo.Add (0);
        tipo.Add (1);
        tipo.Add (2);
        
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Pisos, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }[HttpGet("listar-metros-terreno")]
    public IActionResult ListarMetrosTerreno(){
        //Muestra todos los registros donde los metros_terreno no sean 518 ni 600.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <int> tipo = new List <int> ();
        tipo.Add (518);
        tipo.Add (600);
        
        var filtro = Builders<Inmueble>.Filter.Nin(x => x.MetrosTerreno, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }
}