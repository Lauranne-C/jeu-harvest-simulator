using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GrassPointCloudRenderer : MonoBehaviour
{

    //public Mesh grassMesh;
    //public Material material;

    private Mesh mesh;
    public MeshFilter filter;

    public int seed;
    public Vector2 size;
    public float radius;

    [Range(1, 60000)]
    public int grassNumber;

    public float startHeight = 1000;
    public float grassOffset;

    private Vector3 lastPosition;
    private List<Matrix4x4> materices;

    // Update is called once per frame
    void Update()
    {
        if (lastPosition != this.transform.position)
        {
            Random.InitState(seed);
            List<Vector3> positions = new List<Vector3>(grassNumber);
            int[] indicies = new int[grassNumber];
            List<Color> colors = new List<Color>(grassNumber);
            List<Vector3> normals = new List<Vector3>(grassNumber);
            for (int i = 0; i < grassNumber; ++i)
            {
                float r = Random.Range(-radius, radius);
                float angle = Random.Range(0, 360);
                Vector3 origin = transform.position;
                origin.y = startHeight;
                origin.x += r * Mathf.Cos(angle);
                origin.z += r * Mathf.Sin(angle);
                Ray ray = new Ray(origin, Vector3.down);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    origin = hit.point;
                    origin.y = hit.point.y + grassOffset;
                    origin.x -= this.transform.position.x;
                    origin.z -= this.transform.position.z;

                    positions.Add(origin);
                    indicies[i] = i;
                    colors.Add(new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 1));
                    normals.Add(hit.normal);
                }
            }
            mesh = new Mesh();
            mesh.SetVertices(positions);
            mesh.SetIndices(indicies, MeshTopology.Points, 0);
            mesh.SetColors(colors);
            mesh.SetNormals(normals);
            filter.mesh = mesh;

            lastPosition = this.transform.position;
        }
        //Graphics.DrawMeshInstanced(grassMesh, 0, material, materices);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}