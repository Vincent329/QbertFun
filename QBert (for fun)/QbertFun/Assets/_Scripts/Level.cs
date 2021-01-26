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
        float tempX = prefab.position.x;
        float tempY = prefab.position.y;
        for (int i = 0; i < row; i++)
        {
            // column
            //Instantiate(block, new Vector2(tempX + (-0.48f * i), tempY + (-0.721f * i)), block.transform.rotation);

            for (int j = 0; j < row - i; j++)
            {
                //Instantiate();
                Instantiate(block, new Vector2(tempX + (-0.48f * j), tempY - (0.721f * j)), block.transform.rotation);

            }
            tempX += 0.48f;
            tempY -= 0.721f;

        }
    }
}
