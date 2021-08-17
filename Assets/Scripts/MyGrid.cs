using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGrid : MonoBehaviour {


    private static MyGrid _instance;

    public static MyGrid Instance
    {
        get
        {
            return _instance;
        }
    }

    public static int w = 9;
    public static int h = 16;

    public Transform[,] grid = new Transform[w, h];


    private void Awake()
    {
        _instance = this;
    }


    public Vector2 RoundVector2(Vector2 pos)
    {
        return new Vector2(Mathf.Round(pos.x), Mathf.Round(pos.y));
    }

    public bool IsInside(Vector2 pos)
    {
        return (pos.x >= 0 && pos.x < w-3 && pos.y >= 0);
    }

    public bool IsRowFull(int y)
    {
       
        for (int x=0;x < w-3;x++)
        {
            if (grid[x, y] == null)
            {
             
            }
            else
            {
                //1
                if (grid[x + 1, y] != null && grid[x + 2, y] != null && grid[x + 3, y] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 3, y].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 2, y].gameObject);
                        Destroy(grid[x + 3, y].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 2, y] = null;
                        grid[x + 3, y] = null;

                        return true;
                    }
                }
                //2
                if (grid[x, y + 1] != null && grid[x, y + 2] != null && grid[x, y + 3] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 3].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x, y + 2].gameObject);
                        Destroy(grid[x, y + 3].gameObject);
                        grid[x, y + 1] = null;
                        grid[x, y + 2] = null;
                        grid[x, y + 3] = null;

                        return true;
                    }
                }
                //3
                if (grid[x + 1, y] != null && grid[x + 1, y + 1] != null && grid[x, y + 1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x + 1, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        Destroy(grid[x, y + 1].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 1, y + 1] = null;
                        grid[x, y + 1] = null;

                        return true;
                    }
                }
                //4
                if (grid[x + 1, y] != null && grid[x + 2, y] != null && grid[x, y + 1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 2, y].gameObject);
                        Destroy(grid[x, y + 1].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 2, y] = null;
                        grid[x, y + 1] = null;

                        return true;
                    }
                }
                //5
                if (grid[x + 1, y] != null && grid[x + 2, y] != null && grid[x + 1, y + 1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y].gameObject.tag && grid[x + 1, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 2, y].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 2, y] = null;
                        grid[x + 1, y + 1] = null;

                        return true;
                    }
                }
                //6
                if (grid[x + 1, y] != null && grid[x + 2, y] != null && grid[x + 2, y+1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y].gameObject.tag && grid[x + 2, y].gameObject.tag == grid[x + 2, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 2, y].gameObject);
                        Destroy(grid[x + 2, y + 1].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 2, y] = null;
                        grid[x + 2, y + 1] = null;

                        return true;
                    }
                }
                //7
                if (grid[x + 1, y] != null && grid[x, y + 1] != null && grid[x, y + 2] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x, y + 2].gameObject);
                        grid[x + 1, y] = null;
                        grid[x, y + 1] = null;
                        grid[x, y + 2] = null;

                        return true;
                    }
                }
                //8
                if (grid[x + 1, y] != null && grid[x + 1, y + 1] != null && grid[x + 1, y + 2] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 2].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        Destroy(grid[x + 1, y + 2].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 1, y + 1] = null;
                        grid[x + 1, y + 2] = null;

                        return true;
                    }
                }
                //9
                if (grid[x + 1, y] != null && grid[x + 1, y + 1] != null && grid[x + 2, y +1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x + 1, y].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        Destroy(grid[x + 2, y + 1].gameObject);
                        grid[x + 1, y] = null;
                        grid[x + 1, y + 1] = null;
                        grid[x + 2, y + 1] = null;

                        return true;
                    }
                }

                //10
                if (x - 1 >= 0)
                {
                    if (grid[x - 1, y + 1] != null && grid[x, y + 1] != null && grid[x + 1, y + 1] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x - 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x - 1, y + 1].gameObject);
                            Destroy(grid[x, y + 1].gameObject);
                            Destroy(grid[x + 1, y + 1].gameObject);
                            grid[x - 1, y + 1] = null;
                            grid[x, y + 1] = null;
                            grid[x + 1, y + 1] = null;

                            return true;
                        }
                    }
                }
               

                //11
                if (grid[x , y + 1] != null && grid[x, y + 2] != null && grid[x + 1, y + 1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x, y + 2].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        grid[x, y + 1] = null;
                        grid[x, y + 2] = null;
                        grid[x + 1, y + 1] = null;

                        return true;
                    }
                }

                //12
                if (x - 1 >= 0)
                {
                    if (grid[x, y + 1] != null && grid[x, y + 2] != null && grid[x - 1, y + 1] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 1].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x, y + 1].gameObject);
                            Destroy(grid[x, y + 2].gameObject);
                            Destroy(grid[x - 1, y + 1].gameObject);
                            grid[x, y + 1] = null;
                            grid[x, y + 2] = null;
                            grid[x - 1, y + 1] = null;

                            return true;
                        }
                    }
                }

                //13
                if (x - 2 >= 0)
                {
                    if (grid[x - 1, y] != null && grid[x - 1, y + 1] != null && grid[x - 2, y + 1] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x - 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 2, y + 1].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x - 1, y].gameObject);
                            Destroy(grid[x - 1, y + 1].gameObject);
                            Destroy(grid[x - 2, y + 1].gameObject);
                            grid[x - 1, y] = null;
                            grid[x - 1, y + 1] = null;
                            grid[x - 2, y + 1] = null;

                            return true;
                        }
                    }
                }

                //14
                if (grid[x, y+1] != null && grid[x+1, y + 1] != null && grid[x + 1, y + 2] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x + 1, y].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 2].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        Destroy(grid[x + 1, y + 2].gameObject);
                        grid[x, y + 1] = null;
                        grid[x + 1, y + 1] = null;
                        grid[x + 1, y + 2] = null;

                        return true;
                    }
                }

                //15
                if (x - 1 >= 0)
                {
                    if (grid[x, y + 1] != null && grid[x - 1, y + 1] != null && grid[x - 1, y + 2] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 2].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x, y + 1].gameObject);
                            Destroy(grid[x - 1, y + 1].gameObject);
                            Destroy(grid[x - 2, y + 2].gameObject);
                            grid[x, y + 1] = null;
                            grid[x - 1, y + 1] = null;
                            grid[x - 1, y + 2] = null;

                            return true;
                        }
                    }
                }

                //16
                if (grid[x, y + 1] != null && grid[x, y + 2] != null && grid[x+1, y + 2] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag && grid[x, y].gameObject.tag == grid[x+1, y + 2].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x, y + 2].gameObject);
                        Destroy(grid[x+1, y + 2].gameObject);
                        grid[x, y + 1] = null;
                        grid[x, y + 2] = null;
                        grid[x+1, y + 2] = null;

                        return true;
                    }
                }

                //17
                if (x - 1 >= 0)
                {
                    if (grid[x, y + 1] != null && grid[x, y + 2] != null && grid[x - 1, y + 2] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x, y + 2].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 2].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x, y + 1].gameObject);
                            Destroy(grid[x, y + 2].gameObject);
                            Destroy(grid[x - 1, y + 2].gameObject);
                            grid[x, y + 1] = null;
                            grid[x, y + 2] = null;
                            grid[x - 1, y + 2] = null;

                            return true;
                        }
                    }
                }

                //18
                if (grid[x, y + 1] != null && grid[x + 1, y + 1] != null && grid[x + 2, y + 1] != null)
                {
                    if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x + 2, y + 1].gameObject.tag)
                    {
                        Destroy(grid[x, y].gameObject);
                        grid[x, y] = null;
                        Destroy(grid[x, y + 1].gameObject);
                        Destroy(grid[x + 1, y + 1].gameObject);
                        Destroy(grid[x + 2, y + 1].gameObject);
                        grid[x, y + 1] = null;
                        grid[x + 1, y + 1] = null;
                        grid[x + 2, y + 1] = null;

                        return true;
                    }
                }

                //19
                if (x - 2 >= 0)
                {
                    if (grid[x, y + 1] != null && grid[x - 1, y + 1] != null && grid[x - 2, y + 1] != null)
                    {
                        if (grid[x, y].gameObject.tag == grid[x, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 1, y + 1].gameObject.tag && grid[x, y].gameObject.tag == grid[x - 2, y + 1].gameObject.tag)
                        {
                            Destroy(grid[x, y].gameObject);
                            grid[x, y] = null;
                            Destroy(grid[x, y + 1].gameObject);
                            Destroy(grid[x - 1, y + 1].gameObject);
                            Destroy(grid[x - 2, y + 1].gameObject);
                            grid[x, y + 1] = null;
                            grid[x - 1, y + 1] = null;
                            grid[x - 2, y + 1] = null;

                            return true;
                        }
                    }
                }
            }
        }

        // return true;
        return false;
    }

 

    public void DecreaseRowAbove()
    {
        for(int y = 1; y < h; y++)
        {
            for (int x = 0; x < w - 3; x++)
            {
                if (grid[x, y] != null && grid[x, y - 1] == null)
                {
                    grid[x, y - 1] = grid[x, y];
                    grid[x, y] = null;

                    grid[x, y - 1].position += new Vector3(0, -1, 0);

                    y = 1;
                    x = 0;
                }
            }
        }
    }

    public void DeleteFullRows() {

        int currentLine = 0;

        for (int y = 0; y < h; y++)
        {
            if (IsRowFull(y))
            {
                currentLine++;
          
                DecreaseRowAbove();
         
              //  y = 0;
            }
        }

        FindObjectOfType<GameManager>().SetScore(currentLine);
    }
}
