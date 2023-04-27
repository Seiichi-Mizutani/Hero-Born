using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
//	public GameObject directionLight;
	private Transform lightTransform;

	private Transform camTransform;

	bool pureOfHeart = true;
	bool hasSecretIncantation = true;
	string rareItem = "勇者の剣";

	private int currentAge = 52;
	public int addedAge = -10;
	public float pi = 3.14f;
	public string firstName = "Seiichi";
	public bool isAuthor = false;


	public void OpenTreasureChamber()
	{
		if (pureOfHeart && rareItem == "勇者の剣") {
			if (!hasSecretIncantation) {
				UnityEngine.Debug.Log("test case1");
			}
			else {
				UnityEngine.Debug.Log("test case2");
			}
		}
		else {
			UnityEngine.Debug.Log("test case3");
		}
	}

	/// <summary>
	/// 年齢の合計（整数）を計算する
	/// </summary>
	void ComputeAge()
	{
		UnityEngine.Debug.Log(currentAge + addedAge);
	}

	public int GenerateCharacter(string name, int level)
	{
		UnityEngine.Debug.LogFormat("Chara : {0}, Level : {1}", name, level);
		return (level + 5);
	}

   void Awake()
    {
		UnityEngine.Debug.Log("Awake");
	}

    // Start is called before the first frame update
    void Start()
    {
		UnityEngine.Debug.Log("Start");

		camTransform = this.GetComponent<Transform>();
		UnityEngine.Debug.Log(camTransform.localPosition);

//		directionLight = GameObject.Find("Directional Light");
//		lightTransform = directionLight.GetComponent<Transform>();
		lightTransform = GameObject.Find("Directional Light").GetComponent<Transform>();
		UnityEngine.Debug.Log(lightTransform.localPosition);

		var hero    = new Character("智樹");// 型推論を使った宣言.
		var heroine = new Character("智子");// 型推論を使った宣言.

		hero.PrintStatsInfo();

		var hero2 = hero;				// クラス型の変数は別実体が作られず、参照する.
		hero2.PrintStatsInfo();
		hero2.name = "Sir Krane the Brave";
		hero.PrintStatsInfo();			// hero2の内容を書き換えると、heroの内容にも影響を与える.

//		hero2.Reset();
		hero2.PrintStatsInfo();

		heroine.PrintStatsInfo();

		var huntingBow = new Weapon("Hunting Bow", 105);
		var huntingBow2 = huntingBow;	// 構造体型変数は別実体が作られる.

		huntingBow.PrintWeaponStats();	// コピーしただけなので同じ内容が出力される.
		huntingBow2.PrintWeaponStats();

		huntingBow2.name = "War Bow";	// 武器２の内容を変更する.
		huntingBow2.damage = 155;

		huntingBow.PrintWeaponStats();	// 武器２の内容を書き換えたので、違う内容が出力される.
		huntingBow2.PrintWeaponStats();

		Character knight = new Paladin("アーサー卿", huntingBow2);
		knight.PrintStatsInfo();

/*
		// Dictionaryの使用実践.
		Dictionary<string, int> itemInventory = new Dictionary<string, int>()
		{
			{"Potion",   5},
			{"Antidote", 8},
			{"Aspirin",  1},
		};
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		int number = itemInventory["Potion"];// "Potion"の数を取得.
		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", number);

		itemInventory["Potion"] = number + 1;// "Potion"の数を設定.
		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", itemInventory["Potion"]);

//		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", itemInventory["Bandage"]);// 存在しない要素にアクセスするとビルドエラー.
//		itemInventory.Add("Bandage", 3);	// キーと値のペアを追加する方法その１.
//		itemInventory["Bandage"] = 4;		// キーと値のペアを追加する方法その２
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		// キーの存在を確認する方法.
		if (itemInventory.ContainsKey("Bandage")) {
			itemInventory["Bandage"]++;// キーが存在していればその値を１つ増やす.
		}
		else {
			itemInventory["Bandage"] = 1;// キーと値のペアを追加する、1で初期化しておく.
		}
		UnityEngine.Debug.LogFormat("numberOfAspirin:{0}", itemInventory["Aspirin"]);
		UnityEngine.Debug.LogFormat("numberOfBandage:{0}", itemInventory["Bandage"]);
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		itemInventory.Remove("Antidote");// キーを削除.
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);
*/

/**
		// Dictionaryの使用例.
		Dictionary<int, string> battleShip = new Dictionary<int, string>()
		{
			{10, "能登"},
			{20, "加賀"},
			{30, "比叡"},
		};
		UnityEngine.Debug.LogFormat("battleShip Counts:{0}", battleShip.Count);
		for (int i = 0; i < battleShip.Count; i++) {
			UnityEngine.Debug.LogFormat("battleShip[{0}] = {1}", i, battleShip[(i+1)*10]);
		}
		foreach(KeyValuePair<int, string> kvp in battleShip) {
			UnityEngine.Debug.LogFormat("battleShip[{0}] = {1}", kvp.Key, kvp.Value);
		}
/**/

/**
		// Listの使い方例.
		List<string> questPartyMembers = new List<string>(){"能登", "加賀", "比叡"};
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.Add("武蔵");// リストの最後にデータを追加.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.Insert(1, "大和");// 指定のインデックスの位置にデータを挿入.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.RemoveAt(0);// リストの先頭のデータを削除.
		questPartyMembers.Remove("比叡");// データで指定で削除.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			if (questPartyMembers[i] == "加賀") {
				UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
			}
		}

/**/

/*
		// 配列の使い方例.
		int[] topPlayerScores = new int[] {713, 549, 984};
//		int[] topPlayerScores2 = {713, 549, 984};

		int score = topPlayerScores[1];
		UnityEngine.Debug.Log($"score = {score}");

		topPlayerScores[1] = 1001;
		UnityEngine.Debug.Log($"score = {topPlayerScores[1]}");

		topPlayerScores[2] = 2001;
		UnityEngine.Debug.Log($"score = {topPlayerScores[2]}");

//		topPlayerScores[3] = 3001;
//		UnityEngine.Debug.Log($"score = {topPlayerScores[3]}");

		string characterAction = "deffece";
		switch (characterAction)
		{
			case "Heal":{
				UnityEngine.Debug.Log("薬を送った。");
				break;
			}

			case "Attack":{
				UnityEngine.Debug.Log("攻撃！");
				break;
			}

			default:{
				UnityEngine.Debug.Log("防御せよ！");
				break;
			}
		}

		OpenTreasureChamber();

//		UnityEngine.Debug.Log(30 + 1);
		ComputeAge();
		int level = GenerateCharacter("能登", 99);
		UnityEngine.Debug.Log($"レベル＝{level}");
		UnityEngine.Debug.Log($"文字列には{firstName}のような変数を挿入できる！");
*/
    }

    // Update is called once per frame
    void Update()
    {
		//UnityEngine.Debug.Log("Update");
        
    }
}
