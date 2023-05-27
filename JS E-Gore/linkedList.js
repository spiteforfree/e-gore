class Node {
	constructor(data, next = null) {
	  this.data = data;
	  this.next = next;
 
	}
 }
 
 class LinkedList {
	constructor() {
	  this.head = null;
	  this.size = 0;
 
	}
 
	find(data) {
	  let current = this.head;
 
	  while (current) {
		 if(current.data === data) {
			return current;
		 }
		 current = current.next;
	  }
	  return null;
	}
 
	insertByIndex(data, index) {
	  if (index<0 || index>this.size) {
		 console.log('а вот хуй тебе, введи нормальный индекс по-братски');
	  }
 
	  if (index === 0){
		 this.head = new Node(data, this.head);
	  } else {
		 let current = this.head;
		 let previous;
		 

		 for (let i = 0; i<index; i++) {
			previous = current;
			current = current.next;

		 }
		 previous.next = new Node(data, current);

	  }
	  this.sise++;
 
 
	}

	deleteByValue(data) {
		if (!this.head) {
			return;
		}

		if (this.head.data === data) {
			this.head = this.head.next;
			this.size--;
			return;

		}

		let current = this.head;
		let previous;

		while (current !== null && current.data !== data) {
			previous = current;
			current = current.next;
		}

		if (current == null) {
			return;
		}

		previous.next = current.next;
		this.size--;

	}
 }

 