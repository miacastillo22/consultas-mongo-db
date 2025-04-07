using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
[ApiController]
[Route("api/in")]
public class InController: Controller {
    [HttpGet("listar-tipo")]
    public IActionResult ListarTipo(){
        //Muestra todos los registros donde el tipo sea "Terreno" o "Casa".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Terreno");
        tipo.Add ("Casa");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

[HttpGet("listar-agencia")]
    public IActionResult ListarAgencia(){
      //Muestra todos los registros donde la agencia sea "Inmobiliaria Pérez" o "Agencia ABC".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> agencia = new List <string> ();
        agencia.Add ("Inmobiliaria Pérez");
        agencia.Add ("Agencia ABC");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Agencia, agencia);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-nombre-agente")]
    public IActionResult ListarNombreAgente(){
        //Muestra todos los registros donde el nombre_agente sea "Ana Torres" o "Carlos López".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Ana Torres");
        tipo.Add ("Carlos López");

        var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    [HttpGet("listar-pisos")]
    public IActionResult ListarPisos(){
        //Muestra todos los registros donde los pisos sean 1 o 2.
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <int> tipo = new List <int> ();
        tipo.Add (1);
        tipo.Add (2);

        var filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

[HttpGet("listar-tipo2")]
    public IActionResult ListarTipo2(){
        //Muestra todos los registros donde el tipo sea "Terreno", "Departamento" o "Oficina".
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        List <string> tipo = new List <string> ();
        tipo.Add ("Terreno");
        tipo.Add ("Departamento");
        tipo.Add("Oficina");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Tipo, tipo);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

}

