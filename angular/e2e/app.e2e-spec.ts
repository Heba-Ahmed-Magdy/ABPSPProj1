import { ABPsinglePageProj1TemplatePage } from './app.po';

describe('ABPsinglePageProj1 App', function() {
  let page: ABPsinglePageProj1TemplatePage;

  beforeEach(() => {
    page = new ABPsinglePageProj1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
