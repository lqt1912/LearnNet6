export interface  Card{
  id: string,
  title: string,
  order: number,
  type: number,
  cardAuthor: string,
  estimateValue: number,
  assignedTo: string,
  cardAuthorName: string,
  cardAuthorEmail: string,
  assignedToName: string,
  assignedToEmail: string
}


export interface BoardColumn {
  cardType: number,
  cardValue: Card[]
}
