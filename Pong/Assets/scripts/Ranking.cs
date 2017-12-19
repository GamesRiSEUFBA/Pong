using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;

public class Ranking : MonoBehaviour {

	public string[] nomeJogadores;
	public string[] pontuacaoJogadores;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnEnable(){
		load ();
		print ();
	}

	public void save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "ranking");

		RankingData rankingData = new RankingData ();

		rankingData.nomeJogadores = this.nomeJogadores;
		rankingData.pontuacaoJogadores = this.pontuacaoJogadores;

		bf.Serialize (file, rankingData);
		file.Close();
	}

	public void load(){
		if(File.Exists(Application.persistentDataPath + "ranking")){
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "ranking", FileMode.Open);

			RankingData rankingData = (RankingData)bf.Deserialize(file);
			file.Close();

			this.nomeJogadores =  rankingData.nomeJogadores;
			this.pontuacaoJogadores = rankingData.pontuacaoJogadores;
			
		}
	}

	public void print(){
		string ranking = ""; 
		for (int cont=0; cont < nomeJogadores.Count(); cont++) {
			ranking = ranking + "  " + nomeJogadores [cont] + ":   " + pontuacaoJogadores [cont] + "\n";			
		}

	}


}

[System.Serializable]
public class RankingData{
	public string[] nomeJogadores;
	public string[] pontuacaoJogadores;

}