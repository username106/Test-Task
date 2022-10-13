using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class create : MonoBehaviour
{
    public GameObject _prefab;
    public Transform _self;
    public GameObject _button;
    public InputField V;
    public InputField S;
    public InputField Hz;
    bool _Enabled;
    private float _hz = 5f;
    float timer = 0f;
    public int _V;
    public int _S;
    public float _Hz
    {
        set
        {
            _hz = 60f / value;
        }
        get
        {
            return _hz;
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= _hz)
        {
            timer = timer % _hz;
            one();
        }
    }
    void one()
    {
        if (_Enabled)
        {
            GameObject newest = Instantiate(_prefab, _self.position, _self.rotation);
            move ex = newest.AddComponent<move>();
            ex._Distance = _S;
            ex._Velocity = _V;
            ex._Pos = newest;
        }
    }
    public void Enabler()
    {
        _Enabled = !_Enabled;
    }
    public void ButtonColor()
    {
        if (!_Enabled)
        {
            _button.GetComponent<Image>().color = Color.green;
            Enabler();
        }
        else
        {
            _button.GetComponent<Image>().color = Color.red;
            Enabler();
        }
    }
    public void VReader()
    {
        _V = int.Parse(V.text);
    }
    public void SReader()
    {
        _S = int.Parse(S.text);
    }
    public void HzReader()
    {
        _Hz = float.Parse(Hz.text);
    }
}
