using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoginViewController : MonoBehaviour {

	public GameObject m_loginPanel;
	public GameObject m_registPanel;
	public GameObject m_serverSelectPanel;

	//注册点击
	public void onRegistBtClick()
	{
		m_loginPanel.SetActive (false);
		m_registPanel.SetActive (true);
	}

	//返回登陆界面
	public void onReturnBtClick()
	{
		m_loginPanel.SetActive (true);
		m_registPanel.SetActive (false);
	}

	//点击登陆
	public void onLoginBtClick()
	{
		Debug.Log ("登陆游戏");
		m_serverSelectPanel.SetActive (true);
		m_loginPanel.SetActive(false);
	}

	//进入主城
	public void onEnterGame()
	{
		ViewControllerManager.getInstance ().goTo ("MainScene");
	}

	//点击注册
	public void onRegistServerBtClick()
	{
		Debug.Log ("组册账号到服务器");
	}
}
