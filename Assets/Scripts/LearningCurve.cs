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
	string rareItem = "�E�҂̌�";

	private int currentAge = 52;
	public int addedAge = -10;
	public float pi = 3.14f;
	public string firstName = "Seiichi";
	public bool isAuthor = false;


	public void OpenTreasureChamber()
	{
		if (pureOfHeart && rareItem == "�E�҂̌�") {
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
	/// �N��̍��v�i�����j���v�Z����
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

		var hero    = new Character("�q��");// �^���_���g�����錾.
		var heroine = new Character("�q�q");// �^���_���g�����錾.

		hero.PrintStatsInfo();

		var hero2 = hero;				// �N���X�^�̕ϐ��͕ʎ��̂����ꂸ�A�Q�Ƃ���.
		hero2.PrintStatsInfo();
		hero2.name = "Sir Krane the Brave";
		hero.PrintStatsInfo();			// hero2�̓��e������������ƁAhero�̓��e�ɂ��e����^����.

//		hero2.Reset();
		hero2.PrintStatsInfo();

		heroine.PrintStatsInfo();

		var huntingBow = new Weapon("Hunting Bow", 105);
		var huntingBow2 = huntingBow;	// �\���̌^�ϐ��͕ʎ��̂������.

		huntingBow.PrintWeaponStats();	// �R�s�[���������Ȃ̂œ������e���o�͂����.
		huntingBow2.PrintWeaponStats();

		huntingBow2.name = "War Bow";	// ����Q�̓��e��ύX����.
		huntingBow2.damage = 155;

		huntingBow.PrintWeaponStats();	// ����Q�̓��e�������������̂ŁA�Ⴄ���e���o�͂����.
		huntingBow2.PrintWeaponStats();

		Character knight = new Paladin("�A�[�T�[��", huntingBow2);
		knight.PrintStatsInfo();

/*
		// Dictionary�̎g�p���H.
		Dictionary<string, int> itemInventory = new Dictionary<string, int>()
		{
			{"Potion",   5},
			{"Antidote", 8},
			{"Aspirin",  1},
		};
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		int number = itemInventory["Potion"];// "Potion"�̐����擾.
		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", number);

		itemInventory["Potion"] = number + 1;// "Potion"�̐���ݒ�.
		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", itemInventory["Potion"]);

//		UnityEngine.Debug.LogFormat("numberOfPotioins:{0}", itemInventory["Bandage"]);// ���݂��Ȃ��v�f�ɃA�N�Z�X����ƃr���h�G���[.
//		itemInventory.Add("Bandage", 3);	// �L�[�ƒl�̃y�A��ǉ�������@���̂P.
//		itemInventory["Bandage"] = 4;		// �L�[�ƒl�̃y�A��ǉ�������@���̂Q
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		// �L�[�̑��݂��m�F������@.
		if (itemInventory.ContainsKey("Bandage")) {
			itemInventory["Bandage"]++;// �L�[�����݂��Ă���΂��̒l���P���₷.
		}
		else {
			itemInventory["Bandage"] = 1;// �L�[�ƒl�̃y�A��ǉ�����A1�ŏ��������Ă���.
		}
		UnityEngine.Debug.LogFormat("numberOfAspirin:{0}", itemInventory["Aspirin"]);
		UnityEngine.Debug.LogFormat("numberOfBandage:{0}", itemInventory["Bandage"]);
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);

		itemInventory.Remove("Antidote");// �L�[���폜.
		UnityEngine.Debug.LogFormat("itemInventory Counts:{0}", itemInventory.Count);
*/

/**
		// Dictionary�̎g�p��.
		Dictionary<int, string> battleShip = new Dictionary<int, string>()
		{
			{10, "�\�o"},
			{20, "����"},
			{30, "��b"},
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
		// List�̎g������.
		List<string> questPartyMembers = new List<string>(){"�\�o", "����", "��b"};
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.Add("����");// ���X�g�̍Ō�Ƀf�[�^��ǉ�.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.Insert(1, "��a");// �w��̃C���f�b�N�X�̈ʒu�Ƀf�[�^��}��.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
		}

		questPartyMembers.RemoveAt(0);// ���X�g�̐擪�̃f�[�^���폜.
		questPartyMembers.Remove("��b");// �f�[�^�Ŏw��ō폜.
		UnityEngine.Debug.LogFormat("Party Members:{0}", questPartyMembers.Count);
		for (int i = 0; i < questPartyMembers.Count; i++) {
			if (questPartyMembers[i] == "����") {
				UnityEngine.Debug.LogFormat("Party Member[{0}] = {1}", i, questPartyMembers[i]);
			}
		}

/**/

/*
		// �z��̎g������.
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
				UnityEngine.Debug.Log("��𑗂����B");
				break;
			}

			case "Attack":{
				UnityEngine.Debug.Log("�U���I");
				break;
			}

			default:{
				UnityEngine.Debug.Log("�h�䂹��I");
				break;
			}
		}

		OpenTreasureChamber();

//		UnityEngine.Debug.Log(30 + 1);
		ComputeAge();
		int level = GenerateCharacter("�\�o", 99);
		UnityEngine.Debug.Log($"���x����{level}");
		UnityEngine.Debug.Log($"������ɂ�{firstName}�̂悤�ȕϐ���}���ł���I");
*/
    }

    // Update is called once per frame
    void Update()
    {
		//UnityEngine.Debug.Log("Update");
        
    }
}
