﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GoToMap : MonoBehaviour {

	//マップ画面に移動
	public void OnClick(){
		SceneManager.LoadScene("MapScene");
	}
}
