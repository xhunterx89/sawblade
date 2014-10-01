Collider.OnTriggerEnter : 

Được gọi khi 1 object khác chạm vào. Để sử dụng trigger thì Collider hiện tại phải được gán rigidbody(một dạng hình thái vật lý).
<code>
void OnTriggerEnter(Collider c) {
	if (c.tag == "Player") {
		c.GetComponent<Entity>().TakeDamage(10);
	}
}
</code>


transform.Rotate :

Truyền vào vecto 3 chiều để di chuyển object đến vị trí được truyền.
<code>
transform.Rotate(Vector3.forward * speed * Time.deltaTime,Space.World);
</code>


Ray:

Vẽ một vecto có hướng được truyền vào bằng 2 biến vecto 2 chiều.
<code>
ray = new Ray(new Vector2(x,y), new Vector2(0,dir));
</code>


Physics.Raycast:

Vẽ collider theo hướng vecto ray đã tạo một cách liên tục và tịnh tiến theo giá trị truyền vào.
<code>
Physics.Raycast(ray,out hit,Mathf.Abs(deltaY) + skin,collisionMask)
</code>

