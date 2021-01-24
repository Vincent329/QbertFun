using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int winScore;
    [SerializeField] int row;

    public Block block;
    public Transform prefab;


    // Start is called before the first frame update
    void Start()
    {
        levelLayout();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void levelLayout()
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row - i; j++)
            {
                //Instantiate();
                Instantiate(block, new Vector2(-1.0f * j, 1.0f * i), block.transform.rotation);
            }
        }
    }
}
