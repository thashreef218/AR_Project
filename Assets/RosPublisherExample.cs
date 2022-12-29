using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.UnityRoboticsDemo;

/// <summary>
///
/// </summary>
public class RosPublisherExample : MonoBehaviour
{
    ROSConnection ros;
    public string topicName = "pos_rot";

    // The game object
    public GameObject cube;
    // Publish the cube's position and rotation every N seconds
    public float publishMessageFrequency = 0.5f;

    // Used to determine how much time has elapsed since the last message was published
    //private float timeElapsed;
    
    public FlagManager 

    void Start()
    {
        // start the ROS connection
        ros = ROSConnection.GetOrCreateInstance();
        ros.RegisterPublisher<PosRotMsg>(topicName);
    }

    private void Update()
    {
        /*timeElapsed += Time.deltaTime;

        if (timeElapsed > publishMessageFrequency)
        {
            cube.transform.rotation = Random.rotation;

            PosRotMsg cubePos = new PosRotMsg(
                cube.transform.position.x,
                cube.transform.position.y,
                cube.transform.position.z,
                cube.transform.rotation.x,
                cube.transform.rotation.y,
                cube.transform.rotation.z,
                cube.transform.rotation.w
            );
            }*/
            
            /*if (Cube != null)
        {
            transform.position = Vector2.Lerp(transform.position, cube.transform.position);
            transform.LookAt(cube.transform.position);
        }*/
        
         if (pathfinding != null) 
        {
            pathfinding.Target = gameObject;
        }

            // Finally send the message to server_endpoint.py running in ROS
            ros.Publish(topicName, cubePos);

            //timeElapsed = 0;
        
    }
}
