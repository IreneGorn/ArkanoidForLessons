using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
    {
        [SerializeField] private GameObject _itemPrefab; 
        [SerializeField] public RectTransform _content; 
        public int minItems = 2; 
        public int maxItems = 8;

        void Start()
        {
            int numItems = Random.Range(minItems, maxItems + 1);
            
            for (int i = 0; i < numItems; i++)
            {
                GameObject item = Instantiate(_itemPrefab, _content);
            }
        }
    }
