using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groups : MonoBehaviour {

    public float freezingTime = 0.5f;
    private float pressingButtonTime = 0f;
    private float lastFallTime = 0;

    private void Awake()
    {
        if (!IsValidGridPos())
        {
            Debug.Log(801);
            FindObjectOfType<GameManager>().SetGameOver();
            Destroy(this.gameObject);
        }
    }

    void Start ()
    {
      
	}

	void Update ()
    {
        if (button_.Button_num == 1)
        {
            pressingButtonTime += Time.deltaTime;

            if (pressingButtonTime > freezingTime)
            {
                transform.position -= new Vector3(1, 0,  0);

                if (IsValidGridPos())
                {
                    UpdateGrid();
                }
                else
                {
                    transform.position += new Vector3(1, 0,  0);
                }

                button_.Button_num = 0;
                pressingButtonTime = 0;
            }
        }

        if (button_.Button_num == 2)
        {
            pressingButtonTime += Time.deltaTime;

            if (pressingButtonTime > freezingTime)
            {

                transform.position += new Vector3(1, 0, 0);

                if (IsValidGridPos())
                {
                    UpdateGrid();
                }
                else
                {
                    transform.position -= new Vector3(1, 0, 0);
                }

                button_.Button_num = 0;
                pressingButtonTime = 0;
            }
        }
        if (button_.Button_num == 3)
        {
            pressingButtonTime += Time.deltaTime;

            if (pressingButtonTime > freezingTime)
            {
              
               transform.Rotate(0,0,-90);

                if (IsValidGridPos())
                {
                    UpdateGrid();
                }
                else
                {
                    transform.Rotate(0, 0, 90);
                }

                button_.Button_num = 0;
                pressingButtonTime = 0;
            }
        }

        if (button_.Button_num == 4)
        {
            pressingButtonTime += Time.deltaTime;

            if (pressingButtonTime > freezingTime)
            {

                transform.Rotate(0, 0, 90);

                if (IsValidGridPos())
                {
                    UpdateGrid();
                }
                else
                {
                    transform.Rotate(0, 0, -90);
                }

                button_.Button_num = 0;
                pressingButtonTime = 0;
            }
        }

        Fall();
    }

    void Fall()
    {
        if ((Time.time - lastFallTime) > FindObjectOfType<Previous>().TimeFrame)
        {
            transform.position -= new Vector3(0, 1, 0);

            if (IsValidGridPos())
            {
                UpdateGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                MyGrid.Instance.DeleteFullRows();

                if (transform.position.y >= 10)
                {
                  //  Debug.Log("Game Over");
                    FindObjectOfType<GameManager>().SetGameOver();
                  //  Destroy(this.gameObject);
                }
                else
                {
                    FindObjectOfType<Spanwer>().SpawnNext();            
                }

                enabled = false;
            }

            lastFallTime = Time.time;
        }
    }

    private bool IsValidGridPos()
    {
        foreach(Transform child in transform)
        {
            Vector2 v = MyGrid.Instance.RoundVector2(child.position);

            if (!MyGrid.Instance.IsInside(v))
            {
                Debug.Log(this.gameObject.name);
                return false;
            }
            if (MyGrid.Instance.grid[(int)v.x, (int)v.y] != null && MyGrid.Instance.grid[(int)v.x, (int)v.y].parent != this.transform)
            {      
                Debug.Log(this.gameObject.name);
                return false;
            }
        }
        return true;
    }

    private void UpdateGrid() {
        for(int x = 0; x < MyGrid.w; x++)
        {
            for(int y = 0; y < MyGrid.h; y++)
            {
                if (MyGrid.Instance.grid[x, y] != null)
                {
                    if (MyGrid.Instance.grid[x, y].parent == transform)
                    {
                        MyGrid.Instance.grid[x,y] = null;
                    }
                }
            }
        }

        foreach(Transform child in transform)
        {
            Vector2 v = MyGrid.Instance.RoundVector2(child.position);

            MyGrid.Instance.grid[(int)v.x, (int)v.y] = child;
        }
    }
}
