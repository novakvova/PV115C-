#include<iostream>
using namespace std;
class Box {
protected:
	string name; //S, M, X
	int width;
	int height;
	int price;
public:
	Box() {

	}
	Box(string name, int width, int height)
	{
		this->name = name;
		this->width = width;
		this->height = height;
	}

};

class Box_S : public Box {
public:
	Box_S() : Box("Розмір S", 30, 2) {
		price = 10;
	}
};

class Box_M : public Box {
public:
	Box_M() : Box("Розмір M", 45, 3) {
		price = 15;
	}
};

class Pizza 
{
private:
	string price; //2$
	int weight;
	string name;
	Box* box;
public:
	Pizza() {
		
		name = "no name";
		weight = 0;
		price = "0$";
	}
	Pizza(string name, int weight, string price) {
		this->name = name;
		this->price = price;
		this->weight = weight;
	}
	Pizza(const Pizza & pizza)
	{
		this->name = pizza.name;
		this->price = pizza.price;
		this->weight = pizza.weight;
	}
	string getPrice() { return this->price; }
	void setPrice(string price) { this->price = price; }
	friend ostream & operator<<(ostream &os, const Pizza pizza) {

		os << "Name: " << pizza.name << "\n";
		os << "Price: " << pizza.price << "\n";
		os << "Weight: " << pizza.weight;
		//os << box << '\n';
		return os;
	}
	//ввід даних залишаю для групи
	friend istream& operator>>(istream& is, Pizza pizza) {
		int size = 0;
		cout << "Enter box size(1-S, 2-M): ";
		is >> size;
		if (size == 1)
			pizza.box = new Box_S();
		else
			pizza.box = new Box_M();
	}
	//Поліморфізм

};
int main() 
{
	Pizza pizza;
	cout << pizza <<"\n";
	cout << "Hello!";

	return 0;
}